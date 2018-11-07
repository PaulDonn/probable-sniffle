using System;
using System.Collections.Generic;
using GameMechanics.Actions.Spells;
using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Enums;
using GameMechanics.Traits;

namespace GameMechanics.Classes
{
    public abstract class Class
    {
        public abstract Die HitDie { get; }

        public virtual void AddLevelOne(Creature creature)
        {
            if(creature.AbilityScores != null)
            {
                creature.SetMaxHP(HitDie.Sides + creature.AbilityScores.ConstitutionModifier);
            }
            else
            {
                creature.SetMaxHP(HitDie.Sides);
            }
        }

        public virtual void RemoveLevelOne(Creature creature)
        {
            creature.SetMaxHP(1);
        }

        public virtual void LevelUp(Creature creature)
        {
            if (creature.AbilityScores != null)
            {
                creature.SetMaxHP(creature.MaxHitPoints + HitDie.Roll() + creature.AbilityScores.ConstitutionModifier);
            }
            else
            {
                creature.SetMaxHP(creature.MaxHitPoints + HitDie.Roll());
            }
        }

        public void AddClassTraits(Creature creature)
        {
            AddSavingThrows(creature.SavingThrows);
            AddProficiencies(creature.ProficiencySet);
            AddTraitsAndFeatures(creature.Traits);
            AddLanguages(creature.Languages);
            AddSpells(creature.KnownSpells);
        }

        public void RemoveClassTraits(Creature creature)
        {
            RemoveSavingThrows(creature.SavingThrows);
            RemoveProficiencies(creature.ProficiencySet);
            RemoveTraitsAndFeatures(creature.Traits);
            RemoveLanguages(creature.Languages);
            RemoveSpells(creature.KnownSpells);
        }

        public virtual List<Condition> GetConditionResistances()
        {
            return new List<Condition>();
        }

        public virtual List<Condition> GetConditionImmunities()
        {
            return new List<Condition>();
        }

        protected virtual void AddSavingThrows(List<Ability> savingThrows)
        {
            return;
        }

        protected virtual void RemoveSavingThrows(List<Ability> savingThrows)
        {
            return;
        }

        protected virtual void AddSkills(List<Skill> skills)
        {
            return;
        }

        protected virtual void RemoveSkills(List<Skill> skills)
        {
            return;
        }

        protected virtual void AddProficiencies(ProficiencySet proficiencySet)
        {
            return;
        }

        protected virtual void RemoveProficiencies(ProficiencySet proficiencySet)
        {
            return;
        }

        protected virtual void AddTraitsAndFeatures(List<Trait> traits)
        {
            return;
        }

        protected virtual void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            return;
        }

        protected virtual void AddLanguages(List<Language> languages)
        {
            return;
        }

        protected virtual void RemoveLanguages(List<Language> languages)
        {
            return;
        }

        protected virtual void AddSpells(List<Spell> spells)
        {
            return;
        }

        protected virtual void RemoveSpells(List<Spell> spells)
        {
            return;
        }
    }
}
