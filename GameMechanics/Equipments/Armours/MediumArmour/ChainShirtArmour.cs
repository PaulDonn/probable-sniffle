using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class ChainShirtArmour : Armour
    {

        public override string Name => "Chain Shirt Armour";

        public override decimal Weight => 20M;

        public override decimal Value => 50.00M;

        public override int BaseAC => 13;

        public override bool AddDexModifier => true;

        public override bool LimitDexModifier => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.MediumArmour;
    }

    public class ChainShirtArmourPlus1 : ChainShirtArmour
    {
        public override string Name => "Chain Shirt Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class ChainShirtArmourPlus2 : ChainShirtArmour
    {
        public override string Name => "Chain Shirt Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class ChainShirtArmourPlus3 : ChainShirtArmour
    {
        public override string Name => "Chain Shirt Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
