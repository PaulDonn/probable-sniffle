using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Dice
{
    public class d20 : Die
    {
        public override int Sides { get { return 20; } }

        public int Roll(bool hasAdvantage = false, bool hasDisadvantage = false)
        {
            var roll1 = Roll();
            var roll2 = Roll();
            if(hasAdvantage && !hasDisadvantage)
            {
                return Math.Max(roll1, roll2);
            }
            if(!hasAdvantage && hasDisadvantage)
            {
                return Math.Min(roll1, roll2);
            }
            return Roll();
        }
    }
}
