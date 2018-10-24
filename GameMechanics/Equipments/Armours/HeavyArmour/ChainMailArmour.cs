using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class ChainMailArmour : Armour
    {

        public override string Name => "Chain Mail Armour";

        public override decimal Weight => 55M;

        public override decimal Value => 75.00M;

        public override int BaseAC => 16;

        public override bool HasStealthDisadvantage => true;

        public override int StrengthRequirement => 13;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.HeavyArmour;
    }

    public class ChainMailArmourPlus1 : ChainMailArmour
    {
        public override string Name => "Chain Mail Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class ChainMailArmourPlus2 : ChainMailArmour
    {
        public override string Name => "Chain Mail Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class ChainMailArmourPlus3 : ChainMailArmour
    {
        public override string Name => "Chain Mail Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
