using GameMechanics.Creatures;
using GameMechanics.Enums;
using GameMechanics.Traits;
using GameMechanics.Traits.Senses;
using System.Collections.Generic;
using System.Linq;

namespace GameMechanics.Races.PlayerRaces
{
    public class Dwarf : Race
    {
        public ToolProficiency ToolProficiency { get; }

        public Dwarf(ToolProficiency toolProficiency)
        {
            ToolProficiency = toolProficiency;
        }

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

        protected override void AddTraitsAndFeatures(List<Trait> traits)
        {
            traits.Add(new Darkvision(60));
        }

        protected override void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            var senses = traits.Where(n => n.GetType() == typeof(Sense));
            Trait traitToRemove = null;
            foreach (var trait in senses)
            {
                var sense = trait as Sense;
                if (sense.Name == "Darkvision" && sense.Range == 60)
                {
                    traitToRemove = trait;
                    break;
                }
            }
            if(traitToRemove != null)
            {
                traits.Remove(traitToRemove);
                traitToRemove = null;
            }
        }

        protected override void AddProficiencies(ProficiencySet proficiencySet)
        {
            proficiencySet.WeaponProficiencies.AddRange(new List<WeaponProficiency>
            {
                WeaponProficiency.Battleaxe,
                WeaponProficiency.Handaxe,
                WeaponProficiency.LightHammer,
                WeaponProficiency.Warhammer
            });
            proficiencySet.ToolProficiencies.Add(ToolProficiency);
        }

        protected override void RemoveProficiencies(ProficiencySet proficiencySet)
        {
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Battleaxe);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Handaxe);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.LightHammer);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Warhammer);
            proficiencySet.ToolProficiencies.Remove(ToolProficiency);
        }

        public override List<Condition> GetConditionResistances()
        {
            return new List<Condition>
            {
                Condition.Poisoned
            };
        }

        protected override void AddLanguages(List<Language> languages)
        {
            languages.Add(Language.Common);
            languages.Add(Language.Dwarvish);
        }

        protected override void RemoveLanguages(List<Language> languages)
        {
            languages.Remove(Language.Common);
            languages.Remove(Language.Dwarvish);
        }
    }
}
