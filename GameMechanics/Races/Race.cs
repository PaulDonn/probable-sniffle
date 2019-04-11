using System;
using System.Collections.Generic;
using GameMechanics.Actions.Spells;
using GameMechanics.Creatures;
using GameMechanics.Enums;
using GameMechanics.Traits;

namespace GameMechanics.Races
{
    public abstract class Race
    {
        public abstract int Speed { get; }

        public abstract Size Size { get; }

        public virtual void LevelUp(Creature creature)
        {
            return;
        }

        public virtual List<Condition> GetConditionResistances()
        {
            return new List<Condition>();
        }

        public virtual List<Condition> GetConditionImmunities()
        {
            return new List<Condition>();
        }

        public void AddRaceTraits(Creature creature)
        {
            AddAbilityScoreIncreases(creature.AbilityScores);
            AddSavingThrows(creature.SavingThrows);
            AddProficiencies(creature.ProficiencySet);
            AddTraitsAndFeatures(creature.Traits);
            AddLanguages(creature.Languages);
            AddSpells(creature.KnownSpells);
        }

        public void RemoveRaceTraits(Creature creature)
        {
            RemoveAbilityScoreIncreases(creature.AbilityScores);
            RemoveSavingThrows(creature.SavingThrows);
            RemoveProficiencies(creature.ProficiencySet);
            RemoveTraitsAndFeatures(creature.Traits);
            RemoveLanguages(creature.Languages);
            RemoveSpells(creature.KnownSpells);
        }

        protected virtual void AddAbilityScoreIncreases(AbilityScores scores)
        {
            return;
        }

        protected virtual void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            return;
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

        protected virtual void AddDamageResistances(List<DamageType> resistances)
        {
            return;
        }

        protected virtual void RemoveDamageResistances(List<DamageType> resistances)
        {
            return;
        }

        protected virtual void AddDamageImmunities(List<DamageType> immunities)
        {
            return;
        }

        protected virtual void RemoveDamageImmunities(List<DamageType> immunities)
        {
            return;
        }

        protected virtual void AddDamageWeaknesses(List<DamageType> weaknesses)
        {
            return;
        }

        protected virtual void RemoveDamageWeaknesses(List<DamageType> weaknesses)
        {
            return;
        }
    }
}
