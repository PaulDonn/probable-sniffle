using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Greatclub : Weapon
    {
        private readonly Die _damageDie = new d8();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Greatclub;

        public override string Name => "Greatclub";

        public override decimal Weight => 0.10M;

        public override decimal Value => 20M;

        public override bool IsTwoHanded => true;
    }

    public class GreatclubPlus1 : Greatclub
    {
        public override string Name => "Greatclub +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1000.00M;
    }

    public class GreatclubPlus2 : Greatclub
    {
        public override string Name => "Greatclub +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 4000.00M;
    }

    public class GreatclubPlus3 : Greatclub
    {
        public override string Name => "Greatclub +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 16000.00M;
    }
}
