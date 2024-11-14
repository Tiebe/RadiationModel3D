using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium141m";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 140.92503d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.86d, new List<RadioactiveSubstance> { new GammaParticle(0.01292), new Europium141() } },
            { 0.14d, new List<RadioactiveSubstance> { new BetaParticle(1, 6104000.0), new Samarium141() } },

        };
    }
}
    
    