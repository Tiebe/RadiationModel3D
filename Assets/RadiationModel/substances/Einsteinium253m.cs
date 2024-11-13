
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium253m : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium253m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 253.08494d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    