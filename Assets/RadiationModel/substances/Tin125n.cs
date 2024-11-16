using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin125n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin125n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 124.90982d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00066), new Tin125() } },

        };
    }
}
    
    