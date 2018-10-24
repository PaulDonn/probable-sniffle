using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class StuddedLeatherArmour : Armour
    {

        public override string Name => "Studded Leather Armour";

        public override decimal Weight => 13M;

        public override decimal Value => 45.00M;

        public override int BaseAC => 12;

        public override bool AddDexModifier => true;

        public override bool HasStealthDisadvantage => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.LightArmour;
    }

    public class StuddedLeatherArmourPlus1 : StuddedLeatherArmour
    {
        public override string Name => "Studded Leather Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class StuddedLeatherArmourPlus2 : StuddedLeatherArmour
    {
        public override string Name => "Studded Leather Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class StuddedLeatherArmourPlus3 : StuddedLeatherArmour
    {
        public override string Name => "Studded Leather Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
