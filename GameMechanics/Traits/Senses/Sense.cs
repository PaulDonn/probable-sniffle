using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Traits.Senses
{
    public abstract class Sense : Trait
    {
        public abstract int Range { get; }
    }
}
