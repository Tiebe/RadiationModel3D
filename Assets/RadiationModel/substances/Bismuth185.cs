using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth185 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth185";
        public override double halfLife { get; } = 0.002d;
        public override double atomicWeight { get; } = 184.9976d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    