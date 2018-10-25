using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class HalfPlateArmour : Armour
    {

        public override string Name => "Half Plate Armour";

        public override decimal Weight => 40M;

        public override decimal Value => 750.00M;

        public override int BaseAC => 15;

        public override bool AddDexModifier => true;

        public override bool LimitDexModifier => true;

        public override bool HasStealthDisadvantage => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.MediumArmour;
    }

    public class HalfPlateArmourPlus1 : HalfPlateArmour
    {
        public override string Name => "Half Plate Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class HalfPlateArmourPlus2 : HalfPlateArmour
    {
        public override string Name => "Half Plate Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class HalfPlateArmourPlus3 : HalfPlateArmour
    {
        public override string Name => "Half Plate Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
