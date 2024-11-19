using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium174m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium174m";
        public override double halfLife { get; } = 2.29d;
        public override double atomicWeight { get; } = 173.94245d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00496, 250000.0), new Thulium174() } },
            { 0.015d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3334521.0), new Ytterbium174() } },

        };
    }
}
    
    