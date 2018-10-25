using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Pike : Weapon
    {
        private readonly Die _damageDie = new d10();

        public override DamageType DamageType => DamageType.Piercing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Pike;

        public override string Name => "Pike";

        public override decimal Weight => 18M;

        public override decimal Value => 5.00M;

        public override bool IsTwoHanded => true;

        public override bool IsHeavy => true;

        public override bool HasReach => true;
    }
}
