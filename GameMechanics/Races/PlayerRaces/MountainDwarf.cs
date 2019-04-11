using GameMechanics.Creatures;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class MountainDwarf : Dwarf
    {
        public MountainDwarf(ToolProficiency toolProficiency) : base(toolProficiency)
        {
        }

        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Strength = scores.Strength + 2 <= 20 ? scores.Strength + 2 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Strength -= 2;
            }
        }

        protected override void AddProficiencies(ProficiencySet proficiencySet)
        {
            base.AddProficiencies(proficiencySet);
            proficiencySet.ArmourProficiencies.AddRange(new List<ArmourProficiency>
            {
                ArmourProficiency.LightArmour,
                ArmourProficiency.MediumArmour
            });
        }

        protected override void RemoveProficiencies(ProficiencySet proficiencySet)
        {
            base.RemoveProficiencies(proficiencySet);
            proficiencySet.ArmourProficiencies.Remove(ArmourProficiency.LightArmour);
            proficiencySet.ArmourProficiencies.Remove(ArmourProficiency.MediumArmour);
        }
    }
}
