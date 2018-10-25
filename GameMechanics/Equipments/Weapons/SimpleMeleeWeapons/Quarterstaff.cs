using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Quarterstaff : Weapon
    {
        private readonly Die _damageDie = new d6();

        private readonly Die _versatileDamageDie = new d8();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Quarterstaff;

        public override string Name => "Quarterstaff";

        public override decimal Weight => 4M;

        public override decimal Value => 0.20M;

        public override bool IsVersatile => true;

        public override Die VersatileDamageDie => _versatileDamageDie;
    }
}
