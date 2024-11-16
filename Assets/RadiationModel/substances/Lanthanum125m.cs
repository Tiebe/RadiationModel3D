using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum125m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum125m";
        public override double halfLife { get; } = 0.39d;
        public override double atomicWeight { get; } = 124.92093d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((107000.0, 0.01159)), new Lanthanum125() } },

        };
    }
}
    
    