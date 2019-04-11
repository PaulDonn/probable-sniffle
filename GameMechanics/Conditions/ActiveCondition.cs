using GameMechanics.Creatures;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Conditions
{
    public abstract class ActiveCondition 
    {
        private bool _checkAtStartOfTurn;

        private bool _checkAtEndOfTurn;

        private int _remainingRounds;

        public abstract string Name { get; }

        public virtual int RemainingRounds { get { return _remainingRounds; }}

        public virtual bool CheckAtStartOfTurn { get { return _checkAtStartOfTurn; } }

        public virtual bool CheckAtEndOfTurn { get { return _checkAtEndOfTurn; } }

        public ActiveCondition(int rounds, bool checkAtStartOfTurn = false, bool checkAtEndOfTurn = false)
        {
            _remainingRounds = rounds;
            _checkAtStartOfTurn = checkAtStartOfTurn;
            _checkAtEndOfTurn = checkAtEndOfTurn;
        }

        public int SubtractRound()
        {
            _remainingRounds -= 1;
            return RemainingRounds;
        }

        public virtual List<Ability> SavingThrowAutoFails => new List<Ability>();

        public virtual bool HasAttackDisadvantage => false;

        public virtual bool HasDefenseDisadvantage => false;

        public virtual bool HasAbilityCheckDisadvantage => false;
    }
}
