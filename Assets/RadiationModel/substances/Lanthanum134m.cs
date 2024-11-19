using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum134m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum134m";
        public override double halfLife { get; } = 3e-05d;
        public override double atomicWeight { get; } = 133.90898d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00282, 439000.0), new Lanthanum134() } },

        };
    }
}
    
    