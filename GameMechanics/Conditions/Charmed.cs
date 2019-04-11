using GameMechanics.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Conditions
{
    public class Charmed : ActiveCondition
    {
        public Charmed(Creature charmer, int rounds, bool checkAtStartOfTurn = false, bool checkAtEndOfTurn = false) : base(rounds, checkAtStartOfTurn, checkAtEndOfTurn)
        {
            Charmer = charmer;
        }

        public override string Name => "Charmed";

        public Creature Charmer { get; }
    }
}
