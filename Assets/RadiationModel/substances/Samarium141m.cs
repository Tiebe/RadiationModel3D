using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium141m : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium141m";
        public override double halfLife { get; } = 1356.0d;
        public override double atomicWeight { get; } = 140.91867d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9969d, new List<RadioactiveSubstance> { new BetaParticle(1, 4765000.0), new Promethium141() } },
            { 0.0031d, new List<RadioactiveSubstance> { new GammaParticle(0.00704, 176000.0), new Samarium141() } },

        };
    }
}
    
    