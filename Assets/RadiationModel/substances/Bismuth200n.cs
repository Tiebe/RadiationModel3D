using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth200n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth200n";
        public override double halfLife { get; } = 0.4d;
        public override double atomicWeight { get; } = 199.97859d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0029), new Bismuth200() } },

        };
    }
}
    
    