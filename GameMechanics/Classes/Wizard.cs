using GameMechanics.Creatures;
using GameMechanics.Dice;

namespace GameMechanics.Classes
{
    public class Wizard : Class
    {
        private Die _hitDie = new d6();
        public override Die HitDie { get { return _hitDie; } }

        public override void LevelUp(PlayerCharacter pc)
        {
            throw new System.NotImplementedException();
        }
    }
}
