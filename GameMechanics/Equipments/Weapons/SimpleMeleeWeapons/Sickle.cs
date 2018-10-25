using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Sickle : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Sickle;

        public override string Name => "Sickle";

        public override decimal Weight => 2M;

        public override decimal Value => 1.00M;

        public override bool IsLight => true;
    }
}
