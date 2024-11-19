using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin121m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin121m";
        public override double halfLife { get; } = 1385350192.8d;
        public override double atomicWeight { get; } = 120.90425d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7759999999999999d, new List<RadioactiveSubstance> { new GammaParticle(0.1968, 6300.0), new Tin121() } },
            { 0.22399999999999998d, new List<RadioactiveSubstance> { new BetaParticle(-1, 408900.0), new Antimony121() } },

        };
    }
}
    
    