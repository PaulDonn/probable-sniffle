using GameMechanics.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class MountainDwarf : Dwarf
    {
        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Strength = scores.Strength + 2 <= 20 ? scores.Strength + 2 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Strength -= 2;
            }
        }
    }
}
