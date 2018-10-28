using System;
using System.Collections.Generic;
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
            AddProficiencies(creature.ProficiencySet);
            AddTraitsAndFeatures(creature.Traits);
            AddLanguages(creature.Languages);
        }

        public void RemoveRaceTraits(Creature creature)
        {
            RemoveAbilityScoreIncreases(creature.AbilityScores);
            RemoveProficiencies(creature.ProficiencySet);
            RemoveTraitsAndFeatures(creature.Traits);
            RemoveLanguages(creature.Languages);
        }

        protected virtual void AddAbilityScoreIncreases(AbilityScores scores)
        {
            return;
        }

        protected virtual void RemoveAbilityScoreIncreases(AbilityScores scores)
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
    }
}
