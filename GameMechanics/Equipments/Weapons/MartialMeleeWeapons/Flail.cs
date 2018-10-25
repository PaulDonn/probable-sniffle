using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Flail : Weapon
    {
        private readonly Die _damageDie = new d8();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Flail;

        public override string Name => "Flail";

        public override decimal Weight => 2M;

        public override decimal Value => 10.00M;
    }
}
