using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon205m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon205m";
        public override double halfLife { get; } = 10.0d;
        public override double atomicWeight { get; } = 204.99243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((657000.0, 0.00189)), new Radon205() } },

        };
    }
}
    
    