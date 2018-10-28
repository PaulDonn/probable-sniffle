using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes
{
    public class Fighter : Class
    {
        private Die _hitDie = new d10();
        public override Die HitDie { get { return _hitDie; } }

        public override void LevelUp(Creature creature)
        {
            throw new System.NotImplementedException();
        }
    }
}
