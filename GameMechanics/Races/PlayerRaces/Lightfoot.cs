using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Traits;
using GameMechanics.Utils;

namespace GameMechanics.Races.PlayerRaces
{
    public class Lightfoot : Halfling
    {
        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            base.AddAbilityScoreIncreases(scores);
            if (scores != null)
            {
                scores.Charisma = scores.Charisma + 1 <= 20 ? scores.Charisma + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            base.RemoveAbilityScoreIncreases(scores);
            if (scores != null)
            {
                scores.Charisma -= 1;
            }
        }

        protected override void AddTraitsAndFeatures(List<Trait> traits)
        {
            base.AddTraitsAndFeatures(traits);
            traits.Add(new NaturallyStealthy());
        }

        protected override void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            base.RemoveTraitsAndFeatures(traits);
            var naturallyStealthy = traits.First(n => n.Name == Constants.NaturallyStealthy);
            traits.Remove(naturallyStealthy);
        }
    }
}
