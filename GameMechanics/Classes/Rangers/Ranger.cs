using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes.Rangers
{
    public class Ranger : Class
    {
        private Die _hitDie = new d10();
        public override Die HitDie { get { return _hitDie; } }

        public override void LevelUp(Creature creature)
        {
            throw new System.NotImplementedException();
        }
    }
}
