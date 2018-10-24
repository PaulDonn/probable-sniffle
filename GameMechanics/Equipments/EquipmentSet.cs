using GameMechanics.Equipments.Weapons;
using GameMechanics.Equipments.Armours;
using System;
using System.Collections.Generic;
using System.Text;
using GameMechanics.Equipments.Weapons.Ammunitions;

namespace GameMechanics.Equipments
{
    public class EquipmentSet
    {
        public Armour Armour { get; set; }

        public Weapon Weapon1 { get; set; }

        public Weapon Weapon2 { get; set; }

        public Shield Shield { get; set; }

        public Ammunition Ammunition { get; set; }
               
        public List<string> GetActions()
        {
            var actions = new List<string>();

            if (Weapon1 != null)
                actions.AddRange(Weapon1.GetAvailableActions());
            if (Weapon2 != null)
                actions.AddRange(Weapon2.GetAvailableActions());

            return actions;
        }
    }
}
