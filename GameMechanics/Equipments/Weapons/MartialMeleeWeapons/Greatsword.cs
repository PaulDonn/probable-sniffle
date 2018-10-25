using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Greatsword : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 2;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Greatsword;

        public override string Name => "Greatsword";

        public override decimal Weight => 6M;

        public override decimal Value => 50.00M;

        public override bool IsTwoHanded => true;

        public override bool IsHeavy => true;
    }
}
