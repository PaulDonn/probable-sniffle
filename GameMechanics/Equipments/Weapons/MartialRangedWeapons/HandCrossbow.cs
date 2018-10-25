using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialRangedWeapons
{
    public class HandCrossbow : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.HandCrossbow;

        public override string Name => "Hand Crossbow";

        public override decimal Weight => 3M;

        public override decimal Value => 75.00M;

        public override bool IsRanged => true;

        public override AmmunitionType AmmunitionType => AmmunitionType.Bolt;

        public override int ShortRange => 30 / 5;

        public override int LongRange => 120 / 5;

        public override bool IsLight => true;

        public override bool UsesAmunition => true;

        public override bool RequiresLoading => true;
    }
}
