using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes.Sorcerors
{
    public class Sorceror : Class
    {
        private Die _hitDie = new d6();
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
    }
}
