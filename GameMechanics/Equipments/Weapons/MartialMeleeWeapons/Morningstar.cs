using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Morningstar : Weapon
    {
        private readonly Die _damageDie = new d8();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Morningstar;

        public override string Name => "Morningstar";

        public override decimal Weight => 4M;

        public override decimal Value => 15.00M;
    }
}
