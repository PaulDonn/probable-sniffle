using GameMechanics.Races;
using System;

namespace GameMechanics.Creatures
{
    public class PlayerCharacter : Creature
    {
        public void LevelUp()
        {
            LevelUpRace();
            LevelUpClass();
        }

        public void LevelUpRace()
        {
            Race.LevelUp(this);
        }

        public void LevelUpClass()
        {
            Class.LevelUp(this);
        }
    }
}
