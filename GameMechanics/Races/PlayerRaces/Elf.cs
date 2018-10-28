using System.Collections.Generic;
using System.Linq;
using GameMechanics.Creatures;
using GameMechanics.Enums;
using GameMechanics.Traits;
using GameMechanics.Traits.Senses;
using GameMechanics.Utils;

namespace GameMechanics.Races.PlayerRaces
{
    public class Elf : Race
    {
        public override int Speed => 30 / 5;

        public override Size Size => Size.Medium;

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

        protected override void AddSkills(List<Skill> skills)
        {
            skills.Add(Skill.Perception);
        }

        protected override void RemoveSkills(List<Skill> skills)
        {
            skills.Remove(Skill.Perception);
        }

        protected override void AddTraitsAndFeatures(List<Trait> traits)
        {
            traits.Add(new Darkvision(60));
        }

        protected override void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            var senses = traits.Where(n => n.GetType() == typeof(Sense)) as List<Sense>;
            var darkvision = senses.First(n => n.Name == Constants.Darkvision && n.Range == 60);
            traits.Remove(darkvision);
        }

        protected override void AddLanguages(List<Language> languages)
        {
            languages.AddRange(new List<Language>
            {
                Language.Common,
                Language.Elvish
            });
        }

        protected override void RemoveLanguages(List<Language> languages)
        {
            languages.Remove(Language.Common);
            languages.Remove(Language.Elvish);
        }
    }
}
