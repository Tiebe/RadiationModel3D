using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium81m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium81m";
        public override double halfLife { get; } = 6.0d;
        public override double atomicWeight { get; } = 80.92956d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6920700.0), new Arsenic81() } },
            { 0.01d, new List<RadioactiveSubstance> { new GammaParticle(0.00183, 679100.0), new Germanium81() } },

        };
    }
}
    
    