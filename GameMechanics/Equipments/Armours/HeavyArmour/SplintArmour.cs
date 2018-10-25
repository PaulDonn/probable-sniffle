using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class SplintArmour : Armour
    {

        public override string Name => "Splint Armour";

        public override decimal Weight => 60M;

        public override decimal Value => 200.00M;

        public override int BaseAC => 17;

        public override bool HasStealthDisadvantage => true;

        public override int StrengthRequirement => 15;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.HeavyArmour;
    }

    public class SplintArmourPlus1 : SplintArmour
    {
        public override string Name => "Splint Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class SplintArmourPlus2 : SplintArmour
    {
        public override string Name => "Splint Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class SplintArmourPlus3 : SplintArmour
    {
        public override string Name => "Splint Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
