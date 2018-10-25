using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Rapier : Weapon
    {
        private readonly Die _damageDie = new d8();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Rapier;

        public override string Name => "Rapier";

        public override decimal Weight => 2M;

        public override decimal Value => 25.00M;

        public override bool IsFinesse => true;
    }
}
