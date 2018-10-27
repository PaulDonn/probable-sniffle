using System;
using GameMechanics.Creatures;
using GameMechanics.Enums;

namespace GameMechanics.Races
{
    public abstract class Race
    {
        public abstract int Speed { get; }

        public abstract Size Size { get; }

        public virtual void LevelUp(PlayerCharacter pc)
        {
            return;
        }

        public void AddRaceTraits(Creature creature)
        {
            AddAbilityScoreIncreases(creature.AbilityScores);
            AddProficiencies(creature.ProficiencySet);
            AddTraitsAndFeatures(creature);
        }

        public void RemoveRaceTraits(Creature creature)
        {
            RemoveAbilityScoreIncreases(creature.AbilityScores);
            RemoveProficiencies(creature.ProficiencySet);
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

        protected virtual void AddTraitsAndFeatures(Creature creature)
        {
            return;
        }

        protected virtual void RemoveTraitsAndFeatures(Creature creature)
        {
            return;
        }
    }
}
