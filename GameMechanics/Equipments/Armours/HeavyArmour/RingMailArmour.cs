using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class RingMailArmour : Armour
    {

        public override string Name => "Ring Mail Armour";

        public override decimal Weight => 40M;

        public override decimal Value => 30.00M;

        public override int BaseAC => 14;

        public override bool HasStealthDisadvantage => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.HeavyArmour;
    }

    public class RingMailArmourPlus1 : RingMailArmour
    {
        public override string Name => "Ring Mail Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class RingMailArmourPlus2 : RingMailArmour
    {
        public override string Name => "Ring Mail Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class RingMailArmourPlus3 : RingMailArmour
    {
        public override string Name => "Ring Mail Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
