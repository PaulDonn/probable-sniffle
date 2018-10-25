using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Handaxe : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Handaxe;

        public override string Name => "Handaxe";

        public override decimal Weight => 2M;

        public override decimal Value => 5.00M;

        public override int ShortRange => 20 / 5;

        public override int LongRange => 60 / 5;

        public override bool IsLight => true;

        public override bool IsThrown => true;
    }

    public class HandAxePlus1 : Handaxe
    {
        public override string Name => "Handaxe +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1000.00M;
    }

    public class HandAxePlus2 : Handaxe
    {
        public override string Name => "Handaxe +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 4000.00M;
    }

    public class HandAxePlus3 : Handaxe
    {
        public override string Name => "Handaxe +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 16000.00M;
    }
}
