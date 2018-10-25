using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Halberd : Weapon
    {
        private readonly Die _damageDie = new d10();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Halberd;

        public override string Name => "Halberd";

        public override decimal Weight => 6M;

        public override decimal Value => 20.00M;

        public override bool IsTwoHanded => true;

        public override bool IsHeavy => true;

        public override bool HasReach => true;
    }
}
