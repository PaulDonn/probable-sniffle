﻿using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Enums;
using System.Collections.Generic;

namespace GameMechanics.Classes.Warlocks
{
    public class Warlock : Class
    {
        private Die _hitDie = new d8();
        public override Die HitDie { get { return _hitDie; } }

        public override void AddLevelOne(Creature creature)
        {
            base.AddLevelOne(creature);
        }

        public override void RemoveLevelOne(Creature creature)
        {
            base.RemoveLevelOne(creature);
        }

        public override void LevelUp(Creature creature)
        {
            base.LevelUp(creature);
        }

        protected override void AddSavingThrows(List<Ability> savingThrows)
        {
            savingThrows.AddRange(new List<Ability>
            {
                Ability.Wisdom,
                Ability.Charisma
            });
        }

        protected override void RemoveSavingThrows(List<Ability> savingThrows)
        {
            savingThrows.Remove(Ability.Wisdom);
            savingThrows.Remove(Ability.Charisma);
        }
    }
}
