using GameMechanics.Creatures;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class HillDwarf : Dwarf
    {
        public HillDwarf(ToolProficiency toolProficiency) : base(toolProficiency)
        {
        }

        public override void LevelUp(Creature creature)
        {
            base.LevelUp(creature);
            creature.IncreaseMaxHP(1);
        }

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
