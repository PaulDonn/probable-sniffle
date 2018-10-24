using GameMechanics.Creatures;
using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Equipments.Armours
{
    public abstract class Armour : Equipment
    {
        public abstract int BaseAC { get; }
        public virtual bool AddDexModifier { get { return false; } }
        public virtual bool LimitDexModifier { get { return false; } }
        public virtual int StrengthRequirement { get { return 0; } }
        public virtual bool HasStealthDisadvantage { get { return false; } }
        public abstract ArmourProficiency RequiredProficiency { get; }

        public int GetAC(AbilityScores abilityScores)
        {
            var dexMod = 0;
            if (AddDexModifier)
            {
                dexMod = abilityScores.DexterityModifier;
                if (LimitDexModifier && dexMod > 2)
                {
                    dexMod = 2;
                }
            }
            return BaseAC + dexMod + PlusFactor;
        }
    }
}
