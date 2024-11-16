using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium259 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium259";
        public override double halfLife { get; } = 1.5d;
        public override double atomicWeight { get; } = 259.10059d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    