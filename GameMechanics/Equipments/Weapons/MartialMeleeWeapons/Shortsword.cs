using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Shortsword : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Shortsword;

        public override string Name => "Shortsword";

        public override decimal Weight => 2M;

        public override decimal Value => 10.00M;

        public override bool IsLight => true;

        public override bool IsFinesse => true;
    }
}
