using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialRangedWeapons
{
    public class Longbow : Weapon
    {
        private readonly Die _damageDie = new d8();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Longbow;

        public override string Name => "Longbow";

        public override decimal Weight => 2M;

        public override decimal Value => 50.00M;

        public override bool IsRanged => true;

        public override AmmunitionType AmmunitionType => AmmunitionType.Arrow;

        public override int ShortRange => 150 / 5;

        public override int LongRange => 600 / 5;

        public override bool IsTwoHanded => true;

        public override bool UsesAmunition => true;

        public override bool IsHeavy => true;
    }
}
