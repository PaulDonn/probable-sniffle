using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.Ammunitions
{
    public class BlowgunNeedles : Ammunition
    {
        public override AmmunitionType AmmunitionType => AmmunitionType.Needle;

        public override string Name => "Blowgun Needle";

        public override decimal Weight => 0.02M;

        public override decimal Value => 5M;
    }
}
