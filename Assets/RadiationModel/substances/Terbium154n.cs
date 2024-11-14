using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium154n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium154n";
        public override double halfLife { get; } = 81720.0d;
        public override double atomicWeight { get; } = 153.92489d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3746400.0), new Gadolinium154() } },

        };
    }
}
    
    