using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Encounters;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Enums;
using GameMechanics.Utils;

namespace GameMechanics.Actions.Spells.Evocation.Level0
{
    public class DancingLights : Spell
    {
        public override string Name => Constants.DancingLights;

        public override int MinSpellLevel => 0;

        public override Time CastingTime => Time.Action;

        public override Time Duration => Time.OneMinute;

        public override Range Range => Range._120Feet;

        public override bool RequiresConcentration => true;

        public override bool RequiresVerbal => true;

        public override bool RequiresSomatic => true;

        public override bool RequiresMaterial => true;

        public override void CastSpell(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile, int level)
        {
            targetTile.SpellEffects.Add(this);
        }

        public override void CheckTileSpellEffects(CombatEncounter combatEncounter, Tile tile)
        {
            var coordinates = tile.Coordinates;

            var minX = Math.Max(0, coordinates.x - 1);
            var maxX = Math.Min(combatEncounter.Field.GetLength(0) -1, coordinates.x + 1);
            var minY = Math.Max(0, coordinates.y - 1);
            var maxY = Math.Min(combatEncounter.Field.GetLength(1) - 1, coordinates.y + 1);

            for(int x = minX; x <= maxX; x++)
            {
                for(int y = minY; y <= maxY; y++)
                {
                    combatEncounter.Field[x, y].SetLightLevel(LightLevel.MagicalDim);
                }
            }
        }
    }
}
