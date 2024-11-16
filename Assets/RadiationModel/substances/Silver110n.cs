using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver110n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver110n";
        public override double halfLife { get; } = 21588163.2d;
        public override double atomicWeight { get; } = 109.90624d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9867d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3008300.0), new Cadmium110() } },
            { 0.013300000000000001d, new List<RadioactiveSubstance> { new GammaParticle(0.01054), new Silver110() } },

        };
    }
}
    
    