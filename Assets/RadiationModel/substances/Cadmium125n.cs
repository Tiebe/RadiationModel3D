using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium125n : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium125n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 124.92303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00075), new Cadmium125() } },

        };
    }
}
    
    