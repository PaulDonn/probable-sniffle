using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.Ammunitions
{
    public class SlingBullets : Ammunition
    {
        public override AmmunitionType AmmunitionType => AmmunitionType.Stone;

        public override string Name => "Sling Bullets";

        public override decimal Weight => 0.05M;

        public override decimal Value => 1;
    }
}
