using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum36 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum36";
        public override double halfLife { get; } = 0.09d;
        public override double atomicWeight { get; } = 36.00639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 18390000.0), new Silicon36() } },

        };
    }
}
    
    