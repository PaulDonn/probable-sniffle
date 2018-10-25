using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialRangedWeapons
{
    public class HeavyCrossbow : Weapon
    {
        private readonly Die _damageDie = new d10();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.HeavyCrossbow;

        public override string Name => "Heavy Crossbow";

        public override decimal Weight => 18M;

        public override decimal Value => 50.00M;

        public override bool IsRanged => true;

        public override AmmunitionType AmmunitionType => AmmunitionType.Bolt;

        public override int ShortRange => 100 / 5;

        public override int LongRange => 400 / 5;

        public override bool IsTwoHanded => true;

        public override bool UsesAmunition => true;

        public override bool RequiresLoading => true;

        public override bool IsHeavy => true;
    }
}
