using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver127n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver127n";
        public override double halfLife { get; } = 0.0675d;
        public override double atomicWeight { get; } = 126.93912d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.912d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12031000.0), new Cadmium127() } },
            { 0.08800000000000001d, new List<RadioactiveSubstance> { new GammaParticle(0.00064, 1940000.0), new Silver127() } },

        };
    }
}
    
    