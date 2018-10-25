using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialRangedWeapons
{
    public class Blowgun : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Blowgun;

        public override string Name => "Blowgun";

        public override decimal Weight => 1M;

        public override decimal Value => 10.00M;

        public override bool IsRanged => true;

        public override AmmunitionType AmmunitionType => AmmunitionType.Needle;

        public override int ShortRange => 25 / 5;

        public override int LongRange => 100 / 5;

        public override bool UsesAmunition => true;

        public override bool RequiresLoading => true;
    }
}
