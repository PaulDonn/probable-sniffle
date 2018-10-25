using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.Shields
{
    public class SteelShield : Shield
    {
        public override string Name => "Steel Shield";

        public override decimal Weight => 8M;

        public override decimal Value => 15M;
    }

    public class FineSteelShield : SteelShield
    {
        public override string Name => "Fine Steel Shield";

        public override bool IsMagic => true;
    }
}