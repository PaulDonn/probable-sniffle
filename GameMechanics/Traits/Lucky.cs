using GameMechanics.Dice;
using GameMechanics.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Traits
{
    public class Lucky : Trait
    {
        public Die d20 = new d20();

        public override string Name => Constants.Lucky;

        public override object Use()
        {
            return d20.Roll();
        }
    }
}
