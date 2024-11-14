using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum131 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum131";
        public override double halfLife { get; } = 3540.0d;
        public override double atomicWeight { get; } = 130.91007d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2910000.0), new Barium131() } },

        };
    }
}
    
    