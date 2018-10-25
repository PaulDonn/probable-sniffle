using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Mace : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Mace;

        public override string Name => "Mace";

        public override decimal Weight => 4M;

        public override decimal Value => 5.00M;
    }
}
