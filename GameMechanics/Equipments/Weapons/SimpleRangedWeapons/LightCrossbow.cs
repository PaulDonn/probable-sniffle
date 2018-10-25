using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleRangedWeapons
{
    public class LightCrossbow : Weapon
    {
        private readonly Die _damageDie = new d8();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.LightCrossbow;

        public override string Name => "Light Crossbow";

        public override decimal Weight => 5M;

        public override decimal Value => 25.00M;

        public override AmmunitionType AmmunitionType => AmmunitionType.Bolt;

        public override int ShortRange => 80 / 5;

        public override int LongRange => 320 / 5;

        public override bool IsTwoHanded => true;

        public override bool RequiresLoading => true;

        public override bool IsRanged => true;
    }
}
