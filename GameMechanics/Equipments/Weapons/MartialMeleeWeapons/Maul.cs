using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Maul : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 2;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Maul;

        public override string Name => "Maul";

        public override decimal Weight => 10M;

        public override decimal Value => 10.00M;

        public override bool IsTwoHanded => true;

        public override bool IsHeavy => true;
    }
}
