using GameMechanics.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameMechanics.Creatures
{
    public class ProficiencySet
    {
        public List<ArmourProficiency> ArmourProficiencies { get; set; }
        public List<GamingProficiency> GamingProficiencies { get; set; }
        public List<InstrumentProficiency> InstrumentProficiencies { get; set; }
        public List<ToolProficiency> ToolProficiencies { get; set; }
        public List<VehicleProficiency> VehicleProficiencies { get; set; }
        public List<WeaponProficiency> WeaponProficiencies { get; set; }

        public ProficiencySet()
        {
            ArmourProficiencies = new List<ArmourProficiency>();
            GamingProficiencies = new List<GamingProficiency>();
            InstrumentProficiencies = new List<InstrumentProficiency>();
            ToolProficiencies = new List<ToolProficiency>();
            VehicleProficiencies = new List<VehicleProficiency>();
            WeaponProficiencies = new List<WeaponProficiency>();
        }
    }
}
