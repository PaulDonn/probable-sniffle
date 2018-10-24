using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.Ammunitions
{
    public class IronBolts : Ammunition
    {
        public override AmmunitionType AmmunitionType => AmmunitionType.Bolt;

        public override string Name => "Iron Bolt";

        public override decimal Weight => 0.05M;

        public override decimal Value => 5M;
    }
}
