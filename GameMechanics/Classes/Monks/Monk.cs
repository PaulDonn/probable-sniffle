using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes.Monks
{
    public class Monk : Class
    {
        private Die _hitDie = new d8();
        public override Die HitDie { get { return _hitDie; } }

        public override void LevelUp(Creature creature)
        {
            throw new System.NotImplementedException();
        }
    }
}
