using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialRangedWeapons
{
    public class Net : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.None;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Net;

        public override string Name => "Net";

        public override decimal Weight => 3M;

        public override decimal Value => 1.00M;

        public override bool IsRanged => true;

        public override int ShortRange => 5 / 5;

        public override int LongRange => 15 / 5;

        public override bool IsThrown => true;

        public override bool IsSpecial => true;
    }
}
