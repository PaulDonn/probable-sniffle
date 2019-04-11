using GameMechanics.Creatures;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class WoodElf : Elf
    {
        public override int Speed => 35 / 5;

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

        protected override void AddProficiencies(ProficiencySet proficiencySet)
        {
            base.AddProficiencies(proficiencySet);
            proficiencySet.WeaponProficiencies.AddRange(new List<WeaponProficiency>
            {
                WeaponProficiency.Longsword,
                WeaponProficiency.Shortsword,
                WeaponProficiency.Shortbow,
                WeaponProficiency.Longbow
            });
        }

        protected override void RemoveProficiencies(ProficiencySet proficiencySet)
        {
            base.RemoveProficiencies(proficiencySet);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Longsword);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Shortsword);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Shortbow);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Longbow);
        }
    }
}
