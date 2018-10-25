using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Dagger : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Dagger;

        public override string Name => "Dagger";

        public override decimal Weight => 1M;

        public override decimal Value => 2.00M;

        public override int ShortRange => 20 / 5;

        public override int LongRange => 60 / 5;

        public override bool IsLight => true;

        public override bool IsFinesse => true;

        public override bool IsThrown => true;
    }

    public class DaggerPlus1 : Dagger
    {
        public override string Name => "Dagger +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1000.00M;
    }

    public class DaggerPlus2 : Dagger
    {
        public override string Name => "Dagger +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 4000.00M;
    }

    public class DaggerPlus3 : Dagger
    {
        public override string Name => "Dagger +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 16000.00M;
    }
}
