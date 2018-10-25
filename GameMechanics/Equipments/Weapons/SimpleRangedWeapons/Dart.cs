using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleRangedWeapons
{
    public class Dart : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Dart;

        public override string Name => "Dart";

        public override decimal Weight => 0.00M;

        public override decimal Value => 0.00M;

        public override int ShortRange => 20 / 5;

        public override int LongRange => 60 / 5;

        public override bool IsFinesse => true;

        public override bool IsThrown => true;

        public override bool IsRanged => true;
    }
}
