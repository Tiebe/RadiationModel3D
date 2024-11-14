using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum204n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum204n";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 203.98326d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00061), new Platinum204() } },

        };
    }
}
    
    