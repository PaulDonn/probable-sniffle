using System;
using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes
{
    public abstract class Class
    {
        public abstract Die HitDie { get; }

        public abstract void LevelUp(Creature creature);

        public void AddClassTraits(Creature creature)
        {
            throw new NotImplementedException();
        }
    }
}
