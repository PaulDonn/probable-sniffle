using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Enums;
using GameMechanics.Traits;
using GameMechanics.Utils;

namespace GameMechanics.Races.PlayerRaces
{
    public class Halfling : Race
    {
        public override int Speed => 25 / 5;

        public override Size Size => Size.Small;

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

        protected override void AddTraitsAndFeatures(List<Trait> traits)
        {
            traits.AddRange(new List<Trait>
            {
                new Lucky(),
                new HalflingNimbleness()
            });
        }

        protected override void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            var lucky = traits.First(n => n.Name == Constants.Lucky);
            traits.Remove(lucky);
            var halflingNimbleness = traits.First(n => n.Name == Constants.HalflingNimbleness);
            traits.Remove(halflingNimbleness);
        }

        public override List<Condition> GetConditionResistances()
        {
            var conditions = new List<Condition>
            {
                Condition.Frightened
            };
            return conditions;
        }

        protected override void AddLanguages(List<Language> languages)
        {
            languages.AddRange(new List<Language>{
                Language.Common,
                Language.Halfling
            });
        }

        protected override void RemoveLanguages(List<Language> languages)
        {
            languages.Remove(Language.Common);
            languages.Remove(Language.Halfling);
        }
    }
}
