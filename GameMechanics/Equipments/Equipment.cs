using GameMechanics.Creatures;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments
{
    public abstract class Equipment
    {
        public abstract string Name { get; }
        public abstract decimal Weight { get; }
        public abstract decimal Value { get; }
        public virtual int PlusFactor => 0;
        public virtual bool IsMagic => false;
        public virtual bool RequiresAttunement => false;

        public Creature AttunedCreature;
    }
}
