using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleRangedWeapons
{
    public class Shortbow : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Shortbow;

        public override string Name => "Shortbow";

        public override decimal Weight => 2M;

        public override decimal Value => 25.00M;

        public override bool IsRanged => true;

        public override AmmunitionType AmunitionType => AmmunitionType.Arrow;

        public override int ShortRange => 80 / 5;

        public override int LongRange => 320 / 5;

        public override bool IsTwoHanded => true;
    }

    public class ShortbowPlus1 : Shortbow
    {
        public override string Name => "Shortbow +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1000.00M;
    }

    public class ShortbowPlus2 : Shortbow
    {
        public override string Name => "Shortbow +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 4000.00M;
    }

    public class ShortbowPlus3 : Shortbow
    {
        public override string Name => "Shortbow +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 16000.00M;
    }
}
