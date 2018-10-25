using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Battleaxe : Weapon
    {
        private readonly Die _damageDie = new d8();

        private readonly Die _versatileDamageDie = new d10();

        public override DamageType DamageType => DamageType.Slashing;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Battleaxe;

        public override string Name => "Battleaxe";

        public override decimal Weight => 4M;

        public override decimal Value => 10.00M;

        public override bool IsVersatile => true;

        public override Die VersatileDamageDie => _versatileDamageDie;
    }
}
