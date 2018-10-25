using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.Shields
{
    public class WoodenShield : Shield
    {
        public override string Name => "Wooden Shield";

        public override decimal Weight => 4M;

        public override decimal Value => 5M;
    }

    public class FineWoodenShield : WoodenShield
    {
        public override string Name => "Fine Wooden Shield";

        public override bool IsMagic => true;
    }
}
