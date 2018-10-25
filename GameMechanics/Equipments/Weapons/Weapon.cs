using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Encounters;
using GameMechanics.Enums;
using GameMechanics.Equipments.Weapons.Ammunitions;
using GameMechanics.Utils;
using System;
using System.Collections.Generic;

namespace GameMechanics.Equipments.Weapons
{
    public abstract class Weapon : Equipment
    {
        public abstract DamageType DamageType { get; }
        public abstract Die DamageDie { get; }
        public abstract int NumberOfDice { get; }
        public abstract WeaponProficiency RequiredProficiency { get; }
        public virtual bool IsRanged => false;
        public virtual AmmunitionType AmmunitionType => AmmunitionType.None;
        public virtual int ShortRange => 0;
        public virtual int LongRange => 0;
        public virtual bool IsLight => false;
        public virtual bool IsFinesse => false;
        public virtual bool IsThrown => false;
        public virtual bool IsTwoHanded => false;
        public virtual bool IsVersatile => false;
        public virtual Die VersatileDamageDie => null;
        public virtual bool UsesAmunition => false;
        public virtual bool RequiresLoading => false;
        public bool IsLoaded { get; set; }
        public virtual bool IsHeavy => false;
        public virtual bool HasReach => false;
        public virtual bool IsSpecial => false;
        public virtual bool IsSilvered => false;

        public int RollDamage()
        {
            return DamageDie.Roll(NumberOfDice);
        }

        public List<string> GetAvailableActions()
        {
            List<string> actions = new List<string>();

            if(!IsRanged)
            {
                actions.Add(string.Format("{0} - {1} - {2} - {3}", "Attack", Name, "Melee Weapon Attack", "Action"));
            }
            if (IsRanged)
            {
                actions.Add(string.Format("{0} - {1} - {2} - {3}", "Attack", Name, "Ranged Weapon Attack", "Action"));
            }
            if (IsThrown)
            {
                actions.Add(string.Format("{0} - {1} - {2} - {3}", "Throw", Name, "Ranged Weapon Attack", "Action"));
            }

            return actions;
        }

        public void MakeDefaultAttack(CombatEncounter encounter, Creature attacker, Creature target)
        {
            if(IsRanged)
            {
                MakeRangedWeaponAttack(encounter, attacker, target);
            }
            else
            {
                MakeMeleeWeaponAttack(encounter, attacker, target);
            }
        }

        public void MakeMeleeWeaponAttack(CombatEncounter encounter, Creature attacker, Creature target)
        {
            if (!IsRanged)
            {
                var range = 1;
                if(HasReach)
                {
                    range = 2;
                }
                var attackerCoordinates = encounter.GetCoordinates(attacker);
                var targetCoordinates = encounter.GetCoordinates(target);
                var distance = Util.GetDistance(attackerCoordinates, targetCoordinates);
                if (distance <= range)
                {

                    using (var d20 = new d20())
                    {
                        var toHit = d20.Roll();
                        var abilityModifier = attacker.AbilityScores.StrengthModifier;
                        if (IsFinesse && attacker.AbilityScores.DexterityModifier > attacker.AbilityScores.StrengthModifier)
                        {
                            abilityModifier = attacker.AbilityScores.DexterityModifier;
                        }
                        toHit += abilityModifier;

                        if (attacker.ProficiencySet.WeaponProficiencies.Contains(RequiredProficiency))
                        {
                            toHit += attacker.ProficiencyBonus;
                        }

                        if (toHit >= target.ArmourClass)
                        {
                            target.ReceiveDamage(DamageType, RollDamage() + abilityModifier);
                        }
                    }
                }
                else
                {
                    throw new Exception("The target is out of range");
                }
            }
            else
            {
                throw new Exception("Ranged weapons cannot make melee attacks");
            }
        }

        public void MakeRangedWeaponAttack(CombatEncounter encounter, Creature attacker, Creature target)
        {

            if (IsRanged || IsThrown)
            {
                var attackerCoordinates = encounter.GetCoordinates(attacker);
                var targetCoordinates = encounter.GetCoordinates(target);
                var distance = Util.GetDistance(attackerCoordinates, targetCoordinates);
                if (distance <= LongRange)
                {
                    if (!RequiresLoading || IsLoaded)
                    {
                        using (var d20 = new d20())
                        {
                            var toHit = d20.Roll();
                            var abilityModifier = attacker.AbilityScores.DexterityModifier;
                            Ammunition ammunition = null;
                            if (UsesAmunition)
                            {
                                if (attacker.EquipmentSet.Ammunition?.AmmunitionType == AmmunitionType)
                                {
                                    ammunition = attacker.UseAmmuntion();
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else if (IsThrown && attacker.AbilityScores.StrengthModifier > attacker.AbilityScores.DexterityModifier)
                            {
                                abilityModifier = attacker.AbilityScores.StrengthModifier;
                                if (attacker.EquipmentSet.Weapon1 == this)
                                {
                                    encounter.Field[targetCoordinates.x, targetCoordinates.y].Equipment.Add(attacker.EquipmentSet.Weapon1);
                                    attacker.EquipmentSet.Weapon1 = null;
                                }
                                else
                                {
                                    encounter.Field[targetCoordinates.x, targetCoordinates.y].Equipment.Add(attacker.EquipmentSet.Weapon2);
                                    attacker.EquipmentSet.Weapon2 = null;
                                }
                            }
                            toHit += abilityModifier;

                            if (attacker.ProficiencySet.WeaponProficiencies.Contains(RequiredProficiency))
                            {
                                toHit += attacker.ProficiencyBonus;
                            }

                            if (toHit >= target.ArmourClass)
                            {
                                if (ammunition != null)
                                {
                                    target.ReceiveDamage(DamageType, RollDamage() + abilityModifier + ammunition.BonusDamage);
                                }
                                else
                                {
                                    target.ReceiveDamage(DamageType, RollDamage() + abilityModifier);
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("The weapon is not loaded");
                    }
                }
                else
                {
                    throw new Exception("The target is out of range");
                }
            }
            else
            {
                throw new Exception("Non ranged weapons cannot make ranged attacks");
            }
        }
    }
}
