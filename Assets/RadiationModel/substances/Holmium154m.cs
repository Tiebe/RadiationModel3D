using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium154m";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 153.93087d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5997000.0), new Dysprosium154() } },
            { 1e-05d, new List<RadioactiveSubstance> { new AlphaParticle(5304047.4), new Terbium150() } },
            { 0.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00512, 242000.0), new Holmium154() } },

        };
    }
}
    
    