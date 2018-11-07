using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Enums;
using System.Collections.Generic;

namespace GameMechanics.Classes.Rogues
{
    public class Rogue : Class
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
                Ability.Dexterity,
                Ability.Intelligence
            });
        }

        protected override void RemoveSavingThrows(List<Ability> savingThrows)
        {
            savingThrows.Remove(Ability.Dexterity);
            savingThrows.Remove(Ability.Intelligence);
        }
    }
}
