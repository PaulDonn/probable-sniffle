using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Equipments.Weapons.SimpleMeleeWeapons
{
    public class Club : Weapon
    {
        private readonly Die _damageDie = new d4();

        public override string Name => "Club";

        public override decimal Weight => 2M;

        public override decimal Value => 0.10M;

        public override WeaponProficiency RequiredProficiency => WeaponProficiency.Club;

        public override DamageType DamageType => DamageType.Bludgeoning;

        public override Die DamageDie => _damageDie;

        public override int NumberOfDice => 1;

        public override bool IsLight => true;

    }

    public class ClubPlus1 : Club
    {
        public override string Name => "Club +1";

        public override int PlusFactor => 1;

        public override bool IsMagic => true;

        public override decimal Value => 1000.00M;
    }

    public class ClubPlus2 : Club
    {
        public override string Name => "Club +2";

        public override int PlusFactor => 2;

        public override bool IsMagic => true;

        public override decimal Value => 4000.00M;
    }

    public class ClubPlus3 : Club
    {
        public override string Name => "Club +3";

        public override int PlusFactor => 3;

        public override bool IsMagic => true;

        public override decimal Value => 16000.00M;
    }
}
