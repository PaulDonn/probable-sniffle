using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Enums;
using GameMechanics.Traits;

namespace GameMechanics.Races.PlayerRaces
{
    public class Stout : Halfling
    {
        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            base.AddAbilityScoreIncreases(scores);
            if (scores != null)
            {
                scores.Constitution = scores.Constitution + 1 <= 20 ? scores.Constitution + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            base.RemoveAbilityScoreIncreases(scores);
            if (scores != null)
            {
                scores.Constitution -= 1;
            }
        }

        protected override void AddTraitsAndFeatures(List<Trait> traits)
        {
            base.AddTraitsAndFeatures(traits);
        }

        protected override void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            base.RemoveTraitsAndFeatures(traits);
        }

        public override List<Condition> GetConditionResistances()
        {
            return new List<Condition>
            {
                Condition.Poisoned
            };
        }

        protected override void AddDamageResistances(List<DamageType> resistances)
        {
            resistances.Add(DamageType.Poison);
        }

        protected override void RemoveDamageResistances(List<DamageType> resistances)
        {
            resistances.Remove(DamageType.Poison);
        }
    }
}
