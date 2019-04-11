using GameMechanics.Creatures;
using GameMechanics.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Traits
{
    public class HalflingNimbleness : Trait
    {
        public override string Name => Constants.HalflingNimbleness;

        public object Use(Creature creature, Creature target)
        {
            return (creature.Size < target.Size);
        }
    }
}
