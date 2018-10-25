using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class ScaleMailArmour : Armour
    {

        public override string Name => "Scale Mail Armour";

        public override decimal Weight => 45M;

        public override decimal Value => 50.00M;

        public override int BaseAC => 14;

        public override bool AddDexModifier => true;

        public override bool LimitDexModifier => true;

        public override bool HasStealthDisadvantage => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.MediumArmour;
    }

    public class ScaleMailArmourPlus1 : ScaleMailArmour
    {
        public override string Name => "Scale Mail Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class ScaleMailArmourPlus2 : ScaleMailArmour
    {
        public override string Name => "Scale Mail Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class ScaleMailArmourPlus3 : ScaleMailArmour
    {
        public override string Name => "Scale Mail Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
