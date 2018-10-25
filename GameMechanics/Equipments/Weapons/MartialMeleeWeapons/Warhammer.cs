using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.MartialMeleeWeapons
{
    public class Warhammer : Weapon
    {
        private readonly Die _damageDie = new d8();

        private readonly Die _versatileDamageDie = new d10();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Warhammer;

        public override string Name => "Warhammer";

        public override decimal Weight => 2M;

        public override decimal Value => 15.00M;

        public override bool IsVersatile => true;

        public override Die VersatileDamageDie => _versatileDamageDie;
    }
}
