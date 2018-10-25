using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleRangedWeapons
{
    public class Sling : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Sling;

        public override string Name => "Sling";

        public override decimal Weight => 0.5M;

        public override decimal Value => 0.10M;

        public override bool IsRanged => true;

        public override AmmunitionType AmmunitionType => AmmunitionType.Stone;

        public override int ShortRange => 30 / 5;

        public override int LongRange => 120 / 5;
    }
}
