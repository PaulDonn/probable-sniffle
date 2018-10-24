using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class BreastplateArmour : Armour
    {

        public override string Name => "Breastplate Armour";

        public override decimal Weight => 20M;

        public override decimal Value => 400.00M;

        public override int BaseAC => 14;

        public override bool AddDexModifier => true;

        public override bool LimitDexModifier => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.MediumArmour;
    }

    public class BreastplateArmourPlus1 : BreastplateArmour
    {
        public override string Name => "Breastplate Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class BreastplateArmourPlus2 : BreastplateArmour
    {
        public override string Name => "Breastplate Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class BreastplateArmourPlus3 : BreastplateArmour
    {
        public override string Name => "Breastplate Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
