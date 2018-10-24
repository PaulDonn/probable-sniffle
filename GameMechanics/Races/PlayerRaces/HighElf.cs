using GameMechanics.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class HighElf : Elf
    {
        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Intelligence = scores.Intelligence + 1 <= 20 ? scores.Intelligence + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Intelligence -= 1;
            }
        }
    }
}
