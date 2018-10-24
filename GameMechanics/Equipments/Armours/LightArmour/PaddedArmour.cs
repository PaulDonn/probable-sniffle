using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours.LightArmour
{
    public class PaddedArmour : Armour
    {

        public override string Name => "Padded Armour";

        public override decimal Weight => 8M;

        public override decimal Value => 5.00M;

        public override int BaseAC => 11;

        public override bool AddDexModifier => true;

        public override bool HasStealthDisadvantage => true;

        public override ArmourProficiency RequiredProficiency => ArmourProficiency.LightArmour;
    }

    public class PaddedArmourPlus1 : PaddedArmour
    {
        public override string Name => "Padded Armour +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1500.00M;
    }

    public class PaddedArmourPlus2 : PaddedArmour
    {
        public override string Name => "Padded Armour +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 6000.00M;
    }

    public class PaddedArmourPlus3 : PaddedArmour
    {
        public override string Name => "Padded Armour +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 24000.00M;
    }
}
