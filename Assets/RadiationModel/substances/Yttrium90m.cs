using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium90m";
        public override double halfLife { get; } = 11613.6d;
        public override double atomicWeight { get; } = 89.90787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9999819999999999d, new List<RadioactiveSubstance> { new GammaParticle(0.00182), new Yttrium90() } },
            { 1.8e-05d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2957650.0), new Zirconium90() } },

        };
    }
}
    
    