using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class LeatherArmour : Armour
    {

        public override string Name => "Leather Armour";

        public override decimal Weight => 10M;

        public override decimal Value => 10.00M;

        public override int BaseAC => 11;

        public override bool AddDexModifier => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.LightArmour;
    }

    public class LeatherArmourPlus1 : LeatherArmour
    {
        public override string Name => "Leather Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class LeatherArmourPlus2 : LeatherArmour
    {
        public override string Name => "Leather Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class LeatherArmourPlus3 : LeatherArmour
    {
        public override string Name => "Leather Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
