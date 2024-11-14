using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium175n : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium175n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 174.94547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00082), new Thulium175() } },

        };
    }
}
    
    