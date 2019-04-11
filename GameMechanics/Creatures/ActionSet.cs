using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Creatures
{
    public class ActionSet
    {
        public int RemainingMovement { get; set; }
        public bool HasAction { get; set; }
        public bool HasBonusAction { get; set; }
        public bool HasReaction { get; set; }
        public bool HasInteraction { get; set; }
        
        public void Refresh(int speed)
        {
            RemainingMovement = (speed);
            HasAction = true;
            HasBonusAction = true;
            HasReaction = true;
            HasInteraction = true;
        }

        public void Dash(int speed)
        {
            RemainingMovement += (speed);
        }

        public void Move(int units)
        {
            RemainingMovement -= units;
        }

        public void ExpendAction()
        {
            HasAction = false;
        }

        public void ExpendBonusAction()
        {
            HasBonusAction = false;
        }

        public void ExpendReaction()
        {
            HasReaction = false;
        }

        public void ExpendInteraction()
        {
            HasInteraction = false;
        }
    }
}
