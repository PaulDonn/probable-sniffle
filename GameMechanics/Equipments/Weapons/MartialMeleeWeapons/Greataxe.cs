using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Greataxe : Weapon
    {
        private readonly Die _damageDie = new d12();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Greataxe;

        public override string Name => "Greataxe";

        public override decimal Weight => 7M;

        public override decimal Value => 30.00M;

        public override bool IsTwoHanded => true;

        public override bool IsHeavy => true;
    }
}
