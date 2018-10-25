using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Scimitar : Weapon
    {
        private readonly Die _damageDie = new d6();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Scimitar;

        public override string Name => "Scimitar";

        public override decimal Weight => 3M;

        public override decimal Value => 25.00M;

        public override bool IsLight => true;

        public override bool IsFinesse => true;
    }
}
