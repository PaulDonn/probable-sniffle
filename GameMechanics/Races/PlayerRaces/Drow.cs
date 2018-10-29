using GameMechanics.Actions.Spells;
using GameMechanics.Actions.Spells.Evocation.Level0;
using GameMechanics.Actions.Spells.Evocation.Level1;
using GameMechanics.Creatures;
using GameMechanics.Enums;
using GameMechanics.Traits;
using GameMechanics.Traits.Senses;
using GameMechanics.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameMechanics.Races.PlayerRaces
{
    public class Drow : Elf
    {
        public override void LevelUp(Creature creature)
        {
            if(creature.Level == 3)
            {
                creature.KnownSpells.Add(new FaerieFire());
            }
            if(creature.Level == 5)
            {
                creature.KnownSpells.Add(new Darkness());
            }
        }

        protected override void AddAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.AddAbilityScoreIncreases(scores);
                scores.Charisma = scores.Charisma + 1 <= 20 ? scores.Charisma + 1 : 20;
            }
        }

        protected override void RemoveAbilityScoreIncreases(AbilityScores scores)
        {
            if (scores != null)
            {
                base.RemoveAbilityScoreIncreases(scores);
                scores.Charisma -= 1;
            }
        }

        protected override void AddTraitsAndFeatures(List<Trait> traits)
        {
            base.AddTraitsAndFeatures(traits);
            traits.Add(new Darkvision(120));
        }

        protected override void RemoveTraitsAndFeatures(List<Trait> traits)
        {
            base.RemoveTraitsAndFeatures(traits);
            var senses = traits.Where(n => n.GetType() == typeof(Sense)) as List<Sense>;
            var darkvision = senses.First(n => n.Name == Constants.Darkvision && n.Range == 120);
            traits.Remove(darkvision);
        }

        protected override void AddProficiencies(ProficiencySet proficiencySet)
        {
            base.AddProficiencies(proficiencySet);
            proficiencySet.WeaponProficiencies.AddRange(new List<WeaponProficiency>
            {
                WeaponProficiency.Rapier,
                WeaponProficiency.Shortsword,
                WeaponProficiency.HandCrossbow
            });
        }

        protected override void RemoveProficiencies(ProficiencySet proficiencySet)
        {
            base.RemoveProficiencies(proficiencySet);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Rapier);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.Shortsword);
            proficiencySet.WeaponProficiencies.Remove(WeaponProficiency.HandCrossbow);
        }

        protected override void AddSpells(List<Spell> spells)
        {
            base.AddSpells(spells);
            spells.Add(new DancingLights());
        }

        protected override void RemoveSpells(List<Spell> spells)
        {
            base.RemoveSpells(spells);
            var dancingLights = spells.First(n => n.GetType() == typeof(DancingLights));
            spells.Remove(dancingLights);

        }
    }
}
