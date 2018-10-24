using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Dice
{
    public abstract class Die : IDisposable
    {
        public abstract int Sides { get; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public int Roll()
        {
            return Roll(1);
        }

        public virtual int Roll(int rolls)
        {
            Random rng = new Random();

            int result = 0;

            for(int i = 0; i < rolls; i++)
            {
                result += rng.Next(1, Sides+1);
            }

            return result;
        }
    }
}
