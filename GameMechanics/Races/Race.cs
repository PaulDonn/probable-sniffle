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
            AddProficiencies();
        }

        public void RemoveRaceTraits(Creature creature)
        {
            RemoveAbilityScoreIncreases(creature.AbilityScores);
            RemoveProficiencies();
        }

        protected virtual void AddAbilityScoreIncreases(AbilityScores scores)
        {
            return;
        }

        protected virtual void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            return;
        }

        protected virtual void AddProficiencies()
        {
            return;
        }

        protected virtual void RemoveProficiencies()
        {
            return;
        }
    }
}
