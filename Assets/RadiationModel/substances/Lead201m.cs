using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead201m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead201m";
        public override double halfLife { get; } = 60.8d;
        public override double atomicWeight { get; } = 200.97355d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00197, 629000.0), new Lead201() } },

        };
    }
}
    
    