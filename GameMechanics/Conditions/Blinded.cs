using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Conditions
{
    public class Blinded : ActiveCondition
    {
        public Blinded(int rounds, bool checkAtStartOfTurn = false, bool checkAtEndOfTurn = false) : base(rounds, checkAtStartOfTurn, checkAtEndOfTurn)
        {
        }

        public override string Name => "Blinded";

        public override bool HasAttackDisadvantage => true;

        public override bool HasDefenseDisadvantage => true;
    }
}
