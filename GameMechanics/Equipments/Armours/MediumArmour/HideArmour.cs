using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class HideArmour : Armour
    {

        public override string Name => "Hide Armour";

        public override decimal Weight => 12M;

        public override decimal Value => 10.00M;

        public override int BaseAC => 12;

        public override bool AddDexModifier => true;

        public override bool LimitDexModifier => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.MediumArmour;
    }

    public class HideArmourPlus1 : HideArmour
    {
        public override string Name => "Hide Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class HideArmourPlus2 : HideArmour
    {
        public override string Name => "Hide Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class HideArmourPlus3 : HideArmour
    {
        public override string Name => "Hide Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
