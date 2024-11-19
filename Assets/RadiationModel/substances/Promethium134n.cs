using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium134n : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium134n";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 133.92846d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01033, 120000.0), new Promethium134() } },

        };
    }
}
    
    