using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Weapons.Ammunitions
{
    public abstract class Ammunition : Equipment
    {
        public abstract AmmunitionType AmmunitionType { get; }

        public int Amount { get; set; }

        public virtual int BonusDamage => 0;
        
    }
}
