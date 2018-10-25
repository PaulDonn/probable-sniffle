using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Javelin : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Javelin;

        public override string Name => "Javelin";

        public override decimal Weight => 2M;

        public override decimal Value => 0.50M;

        public override int ShortRange => 30 / 5;

        public override int LongRange => 120 / 5;

        public override bool IsThrown => true;
    }
}
