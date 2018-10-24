using GameMechanics.Actions.Spells;
using GameMechanics.Creatures;
using GameMechanics.Equipments;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Encounters.Tiles
{
    public abstract class Tile
    {
        public (int x, int y) Coordinates { get; set; }

        public List<Creature> Creatures { get; set; }

        public List<Equipment> Equipment { get; set; }

        public List<Spell> SpellEffects { get; set; }

        public bool IsLit => false;

        public Tile()
        {
            Creatures = new List<Creature>();
            Equipment = new List<Equipment>();
            SpellEffects = new List<Spell>();
        }

        public void CheckTileSpellEffects()
        {
            foreach (var spellEffect in SpellEffects)
            {
                spellEffect.CheckTileSpellEffects();
            }
        }
        
    }
}
