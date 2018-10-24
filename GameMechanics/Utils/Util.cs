using System;

namespace GameMechanics.Utils
{
    public static class Util
    {
        public static int HalfDamage(int damage)
        {
            return (int)Math.Floor((double)damage / 2);
        }

        public static int DoubleDamage(int damage)
        {
            return damage * 2;
        }
        
        public static int GetDistance((int x,int y) coordinate1, (int x,int y) coordinate2)
        {
            var xDifference = Math.Abs(coordinate1.x - coordinate2.x);
            var yDifference = Math.Abs(coordinate1.y - coordinate2.y);

            var distanceSquared = (xDifference * xDifference) + (yDifference * yDifference);
            var distance = (int)Math.Floor(Math.Sqrt(distanceSquared));

            return distance;
        }
    }
}
