using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead214m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead214m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 214.00133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00087, 1420000.0), new Lead214() } },

        };
    }
}
    
    