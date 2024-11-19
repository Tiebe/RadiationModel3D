using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon134n : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon134n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 133.90864d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00041, 3025234.0), new Xenon134() } },

        };
    }
}
    
    