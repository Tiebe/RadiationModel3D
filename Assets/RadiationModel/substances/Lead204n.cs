using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead204n : RadioactiveSubstance
    {
        public override string name { get; } = "Lead204n";
        public override double halfLife { get; } = 4015.8d;
        public override double atomicWeight { get; } = 203.97539d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2185900.00001, 0.00057)), new Lead204() } },

        };
    }
}
    
    