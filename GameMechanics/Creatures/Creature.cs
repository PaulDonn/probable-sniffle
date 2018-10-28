using GameMechanics.Backgrounds;
using GameMechanics.Classes;
using GameMechanics.Dice;
using GameMechanics.Enums;
using GameMechanics.Races;
using System;
using System.Collections.Generic;
using GameMechanics.Utils;
using GameMechanics.Conditions;
using GameMechanics.Equipments;
using GameMechanics.Equipments.Armours;
using GameMechanics.Equipments.Weapons;
using GameMechanics.Equipments.Weapons.Ammunitions;
using System.Linq;
using GameMechanics.Actions.Spells;
using GameMechanics.Traits;

namespace GameMechanics.Creatures
{
    public class Creature
    {
        #region Properties
        public string Name { get; private set; }
        public string Faction { get; private set; }
        protected Race Race { get; private set; }
        public Genus Genus { get; private set; }
        public Size Size { get { return Race.Size; } }
        public int Speed { get { return Race.Speed; } }
        public Class Class { get; private set; }
        public Archetype Archetype { get; set; }
        public int Level { get; private set; }
        public int ExperiencePoints { get; private set; }
        public Background Background { get; private set; }
        public Alignment Alignment { get; private set; }
        public int ArmourClass { get { return GetAC(); } }
        public int Initiative { get; private set; }
        public int ProficiencyBonus { get { return GetProficiencyBonus(); } }
        public AbilityScores AbilityScores { get; private set; }
        public List<Ability> SavingThrows { get; private set; }
        public List<Skill> Skills { get; private set; }
        public List<Trait> Traits { get; private set; }
        public ProficiencySet ProficiencySet { get; private set; }
        public ActionSet ActionSet { get; private set; }
        public int MaxHitPoints { get; private set; }
        public int CurrentHitPoints { get; private set; }
        public int TemporaryHitPoints { get; private set; }
        public List<Language> Languages { get; private set; }
        public SpellSlots SpellSlots { get; set; }
        public List<Spell> KnownSpells { get; set; }
        public Ability SpellcastingAbility { get; private set; }
        public int SpellcastingAbilityModifier { get { return GetSpellcastingAbilityModifier(); } }
        public int SpellAttackBonus { get { return SpellcastingAbilityModifier + ProficiencyBonus; } }
        public int SpellSaveDC { get { return SpellAttackBonus + 8; } }
        public List<DamageType> Resistances { get; private set; }
        public List<DamageType> Immunities { get; private set; }
        public List<DamageType> Weaknesses { get; private set; }
        public CreatureState Status { get; private set; }
        public List<ActiveCondition> Conditions { get; set; }
        public int DeathSavingThrowSuccesses { get; private set; }
        public int DeathSavingThrowFailures { get; private set; }
        public Inventory Inventory { get; private set; }
        public EquipmentSet EquipmentSet { get; private set; }

        #endregion

        #region Constructors

        public Creature()
        {
            AbilityScores = new AbilityScores();
            SavingThrows = new List<Ability>();
            Skills = new List<Skill>();
            Traits = new List<Trait>();
            Inventory = new Inventory { Equipment = new List<Equipment>()};
            EquipmentSet = new EquipmentSet();
            Conditions = new List<ActiveCondition>();
            Resistances = new List<DamageType>();
            Immunities = new List<DamageType>();
            Weaknesses = new List<DamageType>();
            SpellSlots = new SpellSlots();
            KnownSpells = new List<Spell>();
            Languages = new List<Language>();
            SpellcastingAbility = Ability.None;
            ProficiencySet = new ProficiencySet();
            ActionSet = new ActionSet();
        }
        
        #endregion

        #region Character Setup

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetMaxHP(int maxHP)
        {
            MaxHitPoints = maxHP;
            CurrentHitPoints = maxHP;
        }

        public void SetRace(Race race)
        {
            if (Race != null)
            {
                Race.RemoveRaceTraits(this);
            }
            Race = race;
            Race.AddRaceTraits(this);
        }

        public void SetClass(Class _class)
        {
            Class = _class;
        }

        public void SetArchetype(Archetype archetype)
        {
            Archetype = archetype;
        }

        public void SetBackground(Background background)
        {
            Background = background;
        }

        public void SetAlignment(Alignment alignment)
        {
            Alignment = alignment;
        }

        public void SetFaction(string faction)
        {
            Faction = faction;
        }
        
        public void SetAbilityScores(AbilityScores abilityScores)
        {
            AbilityScores = abilityScores;
        }

        public void AddKnownSpell(Spell spell)
        {
            KnownSpells.Add(spell);
        }

        public void AddToInventory(Equipment equipment)
        {
            Inventory.Equipment.Add(equipment);
        }

        #endregion

        #region Getters and Updaters

        public void LevelUp()
        {
            Level += 1;
            LevelUpRace();
            LevelUpClass();
        }

        public void LevelUpRace()
        {
            Race.LevelUp(this);
        }

        public void LevelUpClass()
        {
            Class.LevelUp(this);
        }

        public void IncreaseMaxHP(int hp)
        {
            MaxHitPoints += Math.Abs(hp);
        }

        private int GetProficiencyBonus()
        {
            var level = Level;
            if (level < 1) return 0;
            if (level < 5) return 2;
            if (level < 9) return 3;
            if (level < 13) return 4;
            if (level < 17) return 5;
            return 6;
        }

        private int GetSpellcastingAbilityModifier()
        {
            switch (SpellcastingAbility)
            {
                case Ability.Strength:
                    return AbilityScores.StrengthModifier;
                case Ability.Dexterity:
                    return AbilityScores.DexterityModifier;
                case Ability.Constitution:
                    return AbilityScores.ConstitutionModifier;
                case Ability.Intelligence:
                    return AbilityScores.IntelligenceModifier;
                case Ability.Wisdom:
                    return AbilityScores.WisdomModifier;
                case Ability.Charisma:
                    return AbilityScores.CharismaModifier;
                default: return 0;
            }
        }

        public int GetAC()
        {
            var ac = 10;
            //Get Race AC Bonus

            //Get Class AC Bonus

            //Get Archetype AC Bonus

            //Get Armour AC Bonus
            if (EquipmentSet.Armour != null)
            {
                ac = EquipmentSet.Armour.GetAC(AbilityScores);
            }

            //Get Shield AC Bonus
            if (EquipmentSet.Shield != null && ProficiencySet.ArmourProficiencies.Contains(ArmourProficiency.Shields))
            {
                ac += 2;
            }

            //Get Cover AC Bonus

            //Get Spell Effect AC Bonus

            return ac;
        }

        public List<Condition> GetConditionResistances()
        {
            var conditions = new List<Condition>();

            //Get Race Condition Resistances

            //Get Class Condition Resistances

            //Get Archetype Condition Resistances

            //Get Spell Effect Condition Resistances

            return conditions;
        }

        public List<Condition> GetConditionImmunities()
        {
            var conditions = new List<Condition>();

            //Get Race Condition Immunities

            //Get Class Condition Immunities

            //Get Archetype Condition Immunities

            //Get Spell Effect Condition Immunities

            return conditions;
        }

        public CreatureState UpdateStatus()
        {
            if (CurrentHitPoints <= MaxHitPoints)
            {
                Status = CreatureState.Dead;
            }
            else if (CurrentHitPoints < 0)
            {
                Status = CreatureState.Dying;
                CurrentHitPoints = 0;
            }
            else if (CurrentHitPoints == 0 && Status != CreatureState.Dying)
            {
                Status = CreatureState.Stable;
                DeathSavingThrowSuccesses = 0;
                DeathSavingThrowFailures = 0;
            }
            else
            {
                Status = CreatureState.Active;
                DeathSavingThrowSuccesses = 0;
                DeathSavingThrowFailures = 0;
            }
            return Status;
        }

        public void Stabilise()
        {
            if (Status == CreatureState.Dying)
            {
                Status = CreatureState.Stable;
            }
        }

        public void GetInventory()
        {
            Console.WriteLine("**Inventory - Equipment**");
            var equipment = Inventory.Equipment.OrderBy(n => n.Name);
            foreach (var item in equipment)
            {
                Console.WriteLine(string.Format("{0} - {1}lb", item.Name, item.Weight));
            }
            Console.WriteLine();
        }

        public void GetEquipment()
        {
            Console.WriteLine("**Equipped**");
            if (EquipmentSet.Weapon1 == null)
            {
                Console.WriteLine(string.Format("Right Hand: {0}", "None"));
            }
            else
            {
                Console.WriteLine(string.Format("Right Hand: {0}", EquipmentSet.Weapon1.Name));
            }
            if (EquipmentSet.Weapon2 == null && EquipmentSet.Shield == null)
            {
                Console.WriteLine(string.Format("Left Hand: {0}", "None"));
            }
            else
            {
                if (EquipmentSet.Weapon2 != null)
                {
                    Console.WriteLine(string.Format("Left Hand: {0}", EquipmentSet.Weapon2.Name));
                }
                if (EquipmentSet.Shield != null)
                {
                    Console.WriteLine(string.Format("Left Hand: {0}", EquipmentSet.Shield.Name));
                }
            }
            if (EquipmentSet.Armour == null)
            {
                Console.WriteLine(string.Format("Armour: {0}", "None"));
            }
            else
            {
                Console.WriteLine(string.Format("Armour: {0}", EquipmentSet.Armour.Name));
            }
            if (EquipmentSet.Ammunition == null)
            {
                Console.WriteLine(string.Format("Ammunition: {0}", "None"));
            }
            else
            {
                Console.WriteLine(string.Format("Ammunition: {0}", EquipmentSet.Ammunition.Name));
            }

            Console.WriteLine();
        }

        #endregion

        #region ActionSet

        public void GetActions()
        {
            var equipmentActions = EquipmentSet.GetActions();
            if (equipmentActions.Count > 0)
            {
                Console.WriteLine("**Actions - Weapons**");
                foreach (var item in equipmentActions)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }

            var level0Spells = KnownSpells.Where(n => n.MinSpellLevel == 0).OrderBy(n => n.Name);
            if (level0Spells.Count() > 0)
            {
                Console.WriteLine("**Spells - Cantrips**");
                foreach (var item in level0Spells)
                {
                    Console.WriteLine(item.GetAvailableAction());
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 10; i++)
            {
                var levelxSpells = KnownSpells.Where(n => n.MinSpellLevel == i).OrderBy(n => n.Name);
                if (levelxSpells.Count() > 0)
                {
                    Console.WriteLine(string.Format("**Spells - Level {0}**", i));
                    foreach (var item in levelxSpells)
                    {
                        Console.WriteLine(item.GetAvailableAction());
                    }
                    Console.WriteLine();
                }
            }
        }

        private void RefreshActionSet()
        {
            ActionSet.Refresh(Speed);
        }

        private void Dash()
        {
            ActionSet.Dash(Speed);
        }

        private void Move(int units)
        {
            ActionSet.Move(units);
        }

        private void ExpendAction()
        {
            ActionSet.ExpendAction();
        }

        private void ExpendBonusAction()
        {
            ActionSet.ExpendBonusAction();
        }

        private void ExpendReaction()
        {
            ActionSet.ExpendReaction();
        }

        private void ExpendInteraction()
        {
            ActionSet.ExpendInteraction();
        }

        #endregion

        #region Equip

        public void EquipArmour(Armour armour)
        {
            if(Inventory.Equipment.Contains(armour))
            {
                if(EquipmentSet.Armour != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Armour);
                    EquipmentSet.Armour = null;
                }

                EquipmentSet.Armour = armour;
                Inventory.Equipment.Remove(armour);
            }
        }

        public void EquipWeapon1(Weapon weapon, bool twoHanded = false)
        {
            if (Inventory.Equipment.Contains(weapon))
            {
                if (EquipmentSet.Weapon1 != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Weapon1);
                    EquipmentSet.Weapon1 = null;
                }
                if (weapon.IsTwoHanded || (weapon.IsVersatile && twoHanded))
                {
                    if (EquipmentSet.Weapon2 != null)
                    {
                        Inventory.Equipment.Add(EquipmentSet.Weapon2);
                        EquipmentSet.Weapon2 = null;
                    }
                    if (EquipmentSet.Shield != null)
                    {
                        Inventory.Equipment.Add(EquipmentSet.Shield);
                        EquipmentSet.Shield = null;
                    }
                }
                EquipmentSet.Weapon1 = weapon;
                Inventory.Equipment.Remove(weapon);
            }
        }

        public void EquipWeapon2(Weapon weapon)
        {
            if (Inventory.Equipment.Contains(weapon) && weapon.IsLight)
            {
                if (EquipmentSet.Weapon2 != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Weapon2);
                    EquipmentSet.Weapon2 = null;
                }
                if (EquipmentSet.Shield != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Shield);
                    EquipmentSet.Shield = null;
                }
                EquipmentSet.Weapon2 = weapon;
                Inventory.Equipment.Remove(weapon);
            }
        }

        public void EquipShield(Shield shield)
        {
            if (Inventory.Equipment.Contains(shield))
            {
                if (EquipmentSet.Weapon2 != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Weapon2);
                    EquipmentSet.Weapon2 = null;
                }
                if (EquipmentSet.Shield != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Shield);
                    EquipmentSet.Shield = null;
                }
                EquipmentSet.Shield = shield;
                Inventory.Equipment.Remove(shield);
            }
        }

        public void EquipAmmunition(Ammunition ammunition)
        {
            if (Inventory.Equipment.Contains(ammunition))
            {
                if(EquipmentSet.Ammunition != null)
                {
                    Inventory.Equipment.Add(EquipmentSet.Ammunition);
                    EquipmentSet.Ammunition = null;
                }
                EquipmentSet.Ammunition = ammunition;
                Inventory.Equipment.Remove(ammunition);
            }
        }

        public Ammunition UseAmmuntion()
        {
            var ammunition = EquipmentSet.Ammunition;
            EquipmentSet.Ammunition.Amount -= 1;
            if(EquipmentSet.Ammunition.Amount == 0)
            {
                EquipmentSet.Ammunition = null;
            }
            return ammunition;
        }

        #endregion
        
        #region Rolls
        
        public int RollSavingThrow(Ability ability)
        {
            using (var d20 = new d20())
            {
                switch (ability)
                {
                    case Ability.Strength:
                        if (SavingThrows.Contains(Ability.Strength)) return d20.Roll() + AbilityScores.StrengthModifier + ProficiencyBonus;
                        else return d20.Roll() + AbilityScores.StrengthModifier;
                    case Ability.Dexterity:
                        if (SavingThrows.Contains(Ability.Dexterity)) return d20.Roll() + AbilityScores.DexterityModifier + ProficiencyBonus;
                        else return d20.Roll() + AbilityScores.DexterityModifier;
                    case Ability.Constitution:
                        if (SavingThrows.Contains(Ability.Constitution)) return d20.Roll() + AbilityScores.ConstitutionModifier + ProficiencyBonus;
                        else return d20.Roll() + AbilityScores.ConstitutionModifier;
                    case Ability.Intelligence:
                        if (SavingThrows.Contains(Ability.Intelligence)) return d20.Roll() + AbilityScores.IntelligenceModifier + ProficiencyBonus;
                        else return d20.Roll() + AbilityScores.IntelligenceModifier;
                    case Ability.Wisdom:
                        if (SavingThrows.Contains(Ability.Wisdom)) return d20.Roll() + AbilityScores.WisdomModifier + ProficiencyBonus;
                        else return d20.Roll() + AbilityScores.WisdomModifier;
                    case Ability.Charisma:
                        if (SavingThrows.Contains(Ability.Charisma)) return d20.Roll() + AbilityScores.CharismaModifier + ProficiencyBonus;
                        else return d20.Roll() + AbilityScores.CharismaModifier;
                    default:
                        return d20.Roll();
                }
            }
        }

        public void RollInitiative()
        {
            using (var d20 = new d20())
            {
                Initiative = d20.Roll() + AbilityScores.DexterityModifier;
            }
        }

        #endregion
                
        #region Rest
        public void ShortRest()
        {
            throw new NotImplementedException();
        }

        public void LongRest()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Damage and Healing
        public void ReceiveDamage(DamageType damageType, int damage)
        {
            if (Immunities.Contains(damageType))
            {
                return;
            }
            if (Resistances.Contains(damageType))
            {
                if (TemporaryHitPoints >= Util.HalfDamage(damage))
                {
                    TemporaryHitPoints -= Util.HalfDamage(damage);
                }
                else
                {
                    var remainingDamage = Util.HalfDamage(damage) - TemporaryHitPoints;
                    TemporaryHitPoints = 0;
                    CurrentHitPoints -= remainingDamage;
                }
            }
            else if (Weaknesses.Contains(damageType))
            {
                if (TemporaryHitPoints >= Util.DoubleDamage(damage))
                {
                    TemporaryHitPoints -= Util.DoubleDamage(damage);
                }
                else
                {
                    var remainingDamage = Util.DoubleDamage(damage) - TemporaryHitPoints;
                    TemporaryHitPoints = 0;
                    CurrentHitPoints -= remainingDamage;
                }
            }
            else
            {
                if (TemporaryHitPoints >= damage)
                {
                    TemporaryHitPoints -= damage;
                }
                else
                {
                    var remainingDamage = damage - TemporaryHitPoints;
                    TemporaryHitPoints = 0;
                    CurrentHitPoints -= remainingDamage;
                }
            }
            UpdateStatus();
        }

        public void ReceiveHealing(int hitPoints)
        {
            CurrentHitPoints = CurrentHitPoints + hitPoints <= MaxHitPoints ? CurrentHitPoints += hitPoints : MaxHitPoints;

            UpdateStatus();
        }

        public void ReceiveTemporaryHealing(int hitPoints)
        {

        }
        #endregion

    }
}
