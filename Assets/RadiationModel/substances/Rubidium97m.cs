using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium97m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium97m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 96.93726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((76599.99999, 0.01619)), new Rubidium97() } },

        };
    }
}
    
    