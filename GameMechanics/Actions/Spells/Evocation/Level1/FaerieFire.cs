using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Encounters;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Enums;
using GameMechanics.Utils;

namespace GameMechanics.Actions.Spells.Evocation.Level1
{
    public class FaerieFire : Spell
    {
        public override string Name => Constants.FaerieFire;

        public override int MinSpellLevel => 1;

        public override Time CastingTime => Time.Action;

        public override Time Duration => Time.OneMinute;
        
        public override Range Range => Range._120Feet;

        public override bool RequiresConcentration => true;

        public override bool RequiresVerbal => true;

        public override void CastSpell(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile, int level)
        {
            throw new NotImplementedException();
        }
    }
}
