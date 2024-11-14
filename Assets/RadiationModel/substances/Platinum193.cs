using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum193 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum193";
        public override double halfLife { get; } = 1577847600.0d;
        public override double atomicWeight { get; } = 192.96298d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new Iridium193() } },

        };
    }
}
    
    