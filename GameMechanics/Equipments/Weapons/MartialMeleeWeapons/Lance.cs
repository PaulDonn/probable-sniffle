using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Lance : Weapon
    {
        private readonly Die _damageDie = new d12();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Lance;

        public override string Name => "Lance";

        public override decimal Weight => 6M;

        public override decimal Value => 10.00M;

        public override bool HasReach => true;

        public override bool IsSpecial => true;
    }
}
