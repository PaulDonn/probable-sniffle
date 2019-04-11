using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Enums;

namespace GameMechanics.Races.PlayerRaces
{
    public class Human : Race
    {
        private Language Language;

        public override int Speed => 30 / 5;

        public override Size Size => Size.Medium;

        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                scores.Strength = scores.Strength + 1 <= 20 ? scores.Strength + 1 : 20;
                scores.Dexterity = scores.Dexterity + 1 <= 20 ? scores.Dexterity + 1 : 20;
                scores.Constitution = scores.Constitution + 1 <= 20 ? scores.Constitution + 1 : 20;
                scores.Intelligence = scores.Intelligence + 1 <= 20 ? scores.Intelligence + 1 : 20;
                scores.Wisdom = scores.Wisdom + 1 <= 20 ? scores.Wisdom + 1 : 20;
                scores.Charisma = scores.Charisma + 1 <= 20 ? scores.Charisma + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                scores.Strength -= 1;
                scores.Dexterity -= 1;
                scores.Constitution -= 1;
                scores.Intelligence -= 1;
                scores.Wisdom -= 1;
                scores.Charisma -= 1;
            }
        }

        protected override void AddLanguages(List<Language> languages)
        {
            languages.AddRange(new List<Language>
            {
                Language.Common,
                Language
            });
        }

        protected override void RemoveLanguages(List<Language> languages)
        {
            languages.Remove(Language.Common);
            languages.Remove(Language);
        }
    }
}
