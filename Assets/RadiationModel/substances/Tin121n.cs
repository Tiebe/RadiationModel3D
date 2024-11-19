using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin121n : RadioactiveSubstance
    {
        public override string name { get; } = "Tin121n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 120.90639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1998699.99999, 0.00062)), new Tin121() } },

        };
    }
}
    
    