using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium149m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium149m";
        public override double halfLife { get; } = 0.49d;
        public override double atomicWeight { get; } = 148.93018d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.993d, new List<RadioactiveSubstance> { new GammaParticle(0.00047, 2661000.0), new Dysprosium149() } },
            { 0.006999999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 6456000.0), new Terbium149() } },

        };
    }
}
    
    