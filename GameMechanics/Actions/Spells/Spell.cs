using GameMechanics.Creatures;
using GameMechanics.Encounters;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;

namespace GameMechanics.Actions.Spells
{
    public abstract class Spell
    {
        public abstract string Name { get; }

        public abstract int MinSpellLevel { get; }

        public abstract Time CastingTime { get; }

        public abstract Time Duration { get; }

        public abstract Range Range { get; }

        public virtual bool IsRitual { get { return false; } }

        public virtual bool RequiresConcentration { get { return false; } }

        public virtual bool RequiresVerbal { get { return false; } }

        public virtual bool RequiresSomatic { get { return false; } }

        public virtual bool RequiresMaterial { get { return false; } }

        public virtual int MaterialCost { get { return 0; } }

        public virtual string MaterialComponents { get { return string.Empty; } }

        public virtual DamageType DamageType { get { return DamageType.None; } }

        public void Cast(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile)
        {
            CastAtLevel(combatEncounter, caster, targets, targetTile, this.MinSpellLevel);
        }

        public void CastAtLevel(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile, int level)
        {
            ValidateCasting(caster, targets, level);
            ExpendSpellSlot(caster.SpellSlots, level);
            CastSpell(combatEncounter, caster, targets, targetTile, level);
        }

        public abstract void CastSpell(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile, int level);
        
        public virtual void CheckTileSpellEffects(CombatEncounter combatEncounter, Tile tile) { }

        public void ValidateCasting(Creature caster, List<Creature> targets, int level)
        {
            if (!HasSpellSlot(caster.SpellSlots, level)) throw new Exception("No Spell Slot available");
            if (!IsRangeValid(caster,targets)) throw new Exception("The target of the spell is invalid for the spell's range");
        }

        public bool HasSpellSlot(SpellSlots spellSlots, int level)
        {
            if(level >= this.MinSpellLevel && spellSlots != null)
            {
                if(level == 0 && spellSlots.Level0Enabled) return true;
                if (level == 1 && spellSlots.Level1Current > 0) return true;
                if (level == 2 && spellSlots.Level2Current > 0) return true;
                if (level == 3 && spellSlots.Level3Current > 0) return true;
                if (level == 4 && spellSlots.Level4Current > 0) return true;
                if (level == 5 && spellSlots.Level5Current > 0) return true;
                if (level == 6 && spellSlots.Level6Current > 0) return true;
                if (level == 7 && spellSlots.Level7Current > 0) return true;
                if (level == 8 && spellSlots.Level8Current > 0) return true;
                if (level == 9 && spellSlots.Level9Current > 0) return true;
            }
            return false;
        }

        public bool IsRangeValid(Creature caster, List<Creature> targets)
        {
            if (this.Range == Range.Self && caster != targets[0]) return false;
            return true;
        }

        public void ExpendSpellSlot(SpellSlots spellSlots, int level)
        {
            if (level == 1) spellSlots.Level1Current -= 1;
            if (level == 2) spellSlots.Level2Current -= 1;
            if (level == 3) spellSlots.Level3Current -= 1;
            if (level == 4) spellSlots.Level4Current -= 1;
            if (level == 5) spellSlots.Level5Current -= 1;
            if (level == 6) spellSlots.Level6Current -= 1;
            if (level == 7) spellSlots.Level7Current -= 1;
            if (level == 8) spellSlots.Level8Current -= 1;
            if (level == 9) spellSlots.Level9Current -= 1;
        }

        public string GetAvailableAction()
        {
            var actionTime = string.Empty;
            switch(CastingTime)
            {
                case Time.Action:
                    actionTime = "Action";
                    break;
                case Time.BonusAction:
                    actionTime = "Bonus Action";
                    break;
                case Time.Reaction:
                    actionTime = "Reaction";
                    break;
                case Time.Instantaneous:
                    actionTime = "Instantaneous";
                    break;
                case Time.OneMinute:
                    actionTime = "One Minute";
                    break;
            }

            var vsm = string.Empty;
            if (RequiresVerbal)
            {
                vsm += "V";
            }
            if (RequiresSomatic)
            {
                vsm += "S";
            }
            if (RequiresMaterial)
            {
                vsm += "M";

                if (MaterialCost > 0)
                {
                    vsm += "(" + MaterialCost + ")";
                }
            }
            if(string.IsNullOrEmpty(vsm))
            {
                vsm = "None";
            }

            return string.Format("{0} - {1} - {2}", Name, actionTime, vsm);
        }
    }
}
