using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium170";
        public override double halfLife { get; } = 0.96d;
        public override double atomicWeight { get; } = 169.94985d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7000000.0), new Dysprosium170() } },

        };
    }
}
    
    