using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Spear : Weapon
    {
        private readonly Die _damageDie = new d6();

        private readonly Die _versatileDamageDie = new d8();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Spear;

        public override string Name => "Spear";

        public override decimal Weight => 3M;

        public override decimal Value => 1.00M;

        public override int ShortRange => 20 / 5;

        public override int LongRange => 60 / 5;

        public override bool IsThrown => true;

        public override bool IsVersatile => true;

        public override Die VersatileDamageDie => _versatileDamageDie;
    }
}
