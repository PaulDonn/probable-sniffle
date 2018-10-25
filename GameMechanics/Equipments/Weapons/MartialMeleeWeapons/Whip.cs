using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Whip : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Whip;

        public override string Name => "Whip";

        public override decimal Weight => 3M;

        public override decimal Value => 2.00M;

        public override bool IsFinesse => true;

        public override bool HasReach => true;
    }
}
