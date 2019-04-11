using System.Collections.Generic;
using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Classes.Barbarians
{
    public class Barbarian : Class
    {
        private Die _hitDie = new d12();
        public override Die HitDie { get { return _hitDie;  } }

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
                Ability.Strength,
                Ability.Constitution
            });
        }

        protected override void RemoveSavingThrows(List<Ability> savingThrows)
        {
            savingThrows.Remove(Ability.Strength);
            savingThrows.Remove(Ability.Constitution);
        }
    }
}
