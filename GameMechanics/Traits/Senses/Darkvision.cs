using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Traits.Senses
{
    public class Darkvision : Sense
    {
        private int _range;

        public override int Range { get { return _range; } }
        public override string Name => "Darkvision";

        public Darkvision(int range)
        {
            _range = range;
        }
    }
}
