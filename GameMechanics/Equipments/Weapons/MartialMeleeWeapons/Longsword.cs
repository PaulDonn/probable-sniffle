using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Longsword : Weapon
    {
        private readonly Die _damageDie = new d8();

        private readonly Die _versatileDamageDie = new d10();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Longsword;

        public override string Name => "Longsword";

        public override decimal Weight => 3M;

        public override decimal Value => 15.00M;

        public override bool IsVersatile => true;

        public override Die VersatileDamageDie => _versatileDamageDie;
    }
}
