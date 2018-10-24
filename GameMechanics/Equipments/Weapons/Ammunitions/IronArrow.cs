using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.Ammunitions
{
    public class IronArrow : Ammunition
    {
        public override AmmunitionType AmmunitionType => AmmunitionType.Arrow;

        public override string Name => "Iron Arrow";

        public override decimal Weight => 0.05M;

        public override decimal Value => 5M;
    }
}
