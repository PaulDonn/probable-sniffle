using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Conditions
{
    public class Poisoned : ActiveCondition
    {
        public Poisoned(int rounds, bool checkAtStartOfTurn = false, bool checkAtEndOfTurn = false) : base(rounds, checkAtStartOfTurn, checkAtEndOfTurn)
        {
        }

        public override string Name => "Poisoned";

        public override bool HasAttackDisadvantage => true;

        public override bool HasAbilityCheckDisadvantage => true;
    }
}
