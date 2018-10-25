using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class PlateArmour : Armour
    {

        public override string Name => "Plate Armour";

        public override decimal Weight => 65M;

        public override decimal Value => 1500.00M;

        public override int BaseAC => 18;

        public override bool HasStealthDisadvantage => true;

        public override int StrengthRequirement => 15;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.HeavyArmour;
    }

    public class PlateArmourPlus1 : PlateArmour
    {
        public override string Name => "Plate Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class PlateArmourPlus2 : PlateArmour
    {
        public override string Name => "Plate Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class PlateArmourPlus3 : PlateArmour
    {
        public override string Name => "Plate Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
