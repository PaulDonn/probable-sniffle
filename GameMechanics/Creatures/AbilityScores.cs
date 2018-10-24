using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Creatures
{
    public class AbilityScores
    {
        public int Strength { get; set; }
        public int StrengthModifier { get { return this.GetModifier(Strength); } }
        public int Dexterity { get; set; }
        public int DexterityModifier { get { return GetModifier(Dexterity); } }
        public int Constitution { get; set; }
        public int ConstitutionModifier { get { return GetModifier(Constitution); } }
        public int Intelligence { get; set; }
        public int IntelligenceModifier { get { return GetModifier(Intelligence); } }
        public int Wisdom { get; set; }
        public int WisdomModifier { get { return GetModifier(Wisdom); } }
        public int Charisma { get; set; }
        public int CharismaModifier { get { return GetModifier(Charisma); } }

        public AbilityScores()
        {
            Strength = 0;
            Dexterity = 0;
            Constitution = 0;
            Intelligence = 0;
            Wisdom = 0;
            Charisma = 0;
        }

        public AbilityScores(int _str, int _dex, int _con, int _int, int _wis, int _cha)
        {
            Strength = _str;
            Dexterity = _dex;
            Constitution = _con;
            Intelligence = _int;
            Wisdom = _wis;
            Charisma = _cha;
        }

        private int GetModifier(int score)
        {
            var scoreDecimal = Convert.ToDecimal(score);
            decimal ModifierDecimal;

            if (scoreDecimal % 2 == 0)
            {
                ModifierDecimal = (scoreDecimal / 2) - 5;
            }
            else
            {
                ModifierDecimal = ((scoreDecimal - 1) / 2) - 5;
            }
            return Convert.ToInt32(ModifierDecimal);
        }
    }
}
