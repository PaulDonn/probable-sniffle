using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Encounters;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Enums;
using GameMechanics.Utils;

namespace GameMechanics.Actions.Spells.Evocation.Level2
{
    public class Darkness : Spell
    {
        public override string Name => Constants.Darkness;

        public override int MinSpellLevel => 2;

        public override Time CastingTime => Time.Action;

        public override Time Duration => Time.TenMinutes;

        public override Range Range => Range._60Feet;

        public override bool RequiresConcentration => true;

        public override bool RequiresVerbal => true;

        public override bool RequiresMaterial => true;

        public override void CastSpell(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile, int level)
        {
            throw new NotImplementedException();
        }
    }
}
