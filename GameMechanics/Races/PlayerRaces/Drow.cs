using GameMechanics.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class Drow : Elf
    {
        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Charisma = scores.Charisma + 1 <= 20 ? scores.Charisma + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Charisma -= 1;
            }
        }
    }
}
