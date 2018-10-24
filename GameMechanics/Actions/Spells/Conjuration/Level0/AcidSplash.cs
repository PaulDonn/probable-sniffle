using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Creatures;
using GameMechanics.Dice;
using GameMechanics.Enums;

namespace GameMechanics.Actions.Spells.Conjuration.Level0
{
    public class AcidSplash : Spell
    {
        public override string Name => "Acid Splash";

        public override int MinSpellLevel => 0;

        public override Time CastingTime => Time.Action;

        public override Time Duration => Time.Instantaneous;

        public override Range Range => Range._60Feet;

        public override bool RequiresVerbal => base.RequiresVerbal;

        public override bool RequiresSomatic => base.RequiresSomatic;

        public override DamageType DamageType => base.DamageType;

        public override void CastSpell(Creature caster, List<Creature> targets, int level)
        {
            using (var d6 = new d6())
            {
                if (targets[0].RollSavingThrow(Ability.Dexterity) < caster.SpellSaveDC)
                {
                    targets[0].ReceiveDamage(DamageType.Acid, d6.Roll());
                }
                if (targets[1] != null && targets[1].RollSavingThrow(Ability.Dexterity) < caster.SpellSaveDC)
                {
                    targets[1].ReceiveDamage(DamageType.Acid, d6.Roll());
                }
            }
        }
    }
}
