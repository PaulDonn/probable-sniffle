using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.Shields
{
    public class IronShield : Shield
    {
        public override string Name => "Iron Shield";

        public override decimal Weight => 6M;

        public override decimal Value => 10M;
    }

    public class FineIronShield : IronShield
    {
        public override string Name => "Fine Iron Shield";

        public override bool IsMagic => true;
    }
}