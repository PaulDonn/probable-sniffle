using GameMechanics.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class WoodElf : Elf
    {
        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Wisdom = scores.Wisdom + 1 <= 20 ? scores.Wisdom + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Wisdom -= 1;
            }
        }
    }
}
