using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury195m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury195m";
        public override double halfLife { get; } = 149760.0d;
        public override double atomicWeight { get; } = 194.9669d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.542d, new List<RadioactiveSubstance> { new GammaParticle(0.00704), new Mercury195() } },
            { 0.45799999999999996d, new List<RadioactiveSubstance> { new BetaParticle(1, 1730100.0), new Gold195() } },

        };
    }
}
    
    