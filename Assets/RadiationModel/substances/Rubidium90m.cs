using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium90m : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium90m";
        public override double halfLife { get; } = 258.0d;
        public override double atomicWeight { get; } = 89.91491d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9740000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6691900.0), new Strontium90() } },
            { 0.025d, new List<RadioactiveSubstance> { new GammaParticle(0.01159), new Rubidium90() } },

        };
    }
}
    
    