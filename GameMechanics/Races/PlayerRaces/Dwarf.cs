using GameMechanics.Creatures;
using GameMechanics.Enums;

namespace GameMechanics.Races.PlayerRaces
{
    public class Dwarf : Race
    {
        public override int Speed { get { return 25; } }

        public override Size Size { get { return Size.Medium; } }

        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                scores.Constitution = scores.Constitution + 2 <= 20 ? scores.Constitution + 2 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                scores.Constitution -= 2;
            }
        }
    }
}
