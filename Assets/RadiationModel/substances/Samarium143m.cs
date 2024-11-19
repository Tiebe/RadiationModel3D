using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium143m";
        public override double halfLife { get; } = 66.0d;
        public override double atomicWeight { get; } = 142.91544d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((754000.0, 0.00164)), new Samarium143() } },
            { 0.0024d, new List<RadioactiveSubstance> { new BetaParticle(1, 4197600.0), new Promethium143() } },

        };
    }
}
    
    