using GameMechanics.Creatures;
using GameMechanics.Enums;

namespace GameMechanics.Races.PlayerRaces
{
    public class Elf : Race
    {
        public override int Speed { get { return 30; } }

        public override Size Size { get { return Size.Medium; } }

        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                scores.Dexterity = scores.Dexterity + 2 <= 20 ? scores.Dexterity + 2 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                scores.Dexterity -= 2;
            }
        }
    }
}
