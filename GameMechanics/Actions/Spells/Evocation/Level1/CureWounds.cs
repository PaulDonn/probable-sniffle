using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Encounters;
using GameMechanics.Encounters.Tiles;
using GameMechanics.Enums;
using System.Collections.Generic;

namespace GameMechanics.Actions.Spells.Evocation.Level1
{
    public class CureWounds : Spell
    {
        public override string Name { get { return "Cure Wounds"; } }

        public override int MinSpellLevel { get { return 1; } }

        public override Time CastingTime { get { return Time.Action; } }

        public override Time Duration { get { return Time.Instantaneous; } }

        public override Range Range { get { return Range.Touch; } }

        public override void CastSpell(CombatEncounter combatEncounter, Creature caster, List<Creature> targets, Tile targetTile, int level)
        {
            using (var d8 = new d8())
            {
                var higherLevels = level - this.MinSpellLevel;
                var hitPoints = d8.Roll(1 + higherLevels) + caster.SpellcastingAbilityModifier;

                targets[0].ReceiveHealing(hitPoints);
            }
        }
    }
}
