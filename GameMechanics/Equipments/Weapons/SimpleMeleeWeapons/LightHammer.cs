using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class LightHammer : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.LightHammer;

        public override string Name => "Light Hammer";

        public override decimal Weight => 2M;

        public override decimal Value => 2.00M;

        public override int ShortRange => 20 / 5;

        public override int LongRange => 60 / 5;

        public override bool IsLight => true;

        public override bool IsThrown => true;
    }
}
