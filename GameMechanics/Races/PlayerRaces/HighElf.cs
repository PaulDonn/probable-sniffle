using GameMechanics.Actions.Spells;
using GameMechanics.Actions.Spells.Evocation.Level0;
using GameMechanics.Creatures;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class HighElf : Elf
    {
        private Spell Cantrip;

        private Language Language;

        public HighElf(Spell cantrip, Language language)
        {
            if(cantrip.MinSpellLevel == 0)
            {
                Cantrip = cantrip;
            }
            else
            {
                Cantrip = new DancingLights();
            }
            Language = language;
        }

        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Intelligence = scores.Intelligence + 1 <= 20 ? scores.Intelligence + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Intelligence -= 1;
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

        protected override void AddSpells(List<Spell> spells)
        {
            base.AddSpells(spells);
            spells.Add(Cantrip);
        }

        protected override void RemoveSpells(List<Spell> spells)
        {
            base.RemoveSpells(spells);
            spells.Remove(Cantrip);
        }

        protected override void AddLanguages(List<Language> languages)
        {
            base.AddLanguages(languages);
            languages.Add(Language);
        }

        protected override void RemoveLanguages(List<Language> languages)
        {
            base.RemoveLanguages(languages);
            languages.Remove(Language);
        }
    }
}
