using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Enums;
using System.Collections.Generic;

namespace GameMechanics.Classes.Druids
{
    public class Druid : Class
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
                Ability.Intelligence,
                Ability.Wisdom
            });
        }

        protected override void RemoveSavingThrows(List<Ability> savingThrows)
        {
            savingThrows.Remove(Ability.Intelligence);
            savingThrows.Remove(Ability.Wisdom);
        }
    }
}
