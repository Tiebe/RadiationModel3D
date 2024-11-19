using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium158m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium158m";
        public override double halfLife { get; } = 1680.0d;
        public override double atomicWeight { get; } = 157.92902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.91d, new List<RadioactiveSubstance> { new GammaParticle((67000.0, 0.01851)), new Holmium158() } },
            { 0.09d, new List<RadioactiveSubstance> { new BetaParticle(1, 4287200.0), new Dysprosium158() } },

        };
    }
}
    
    