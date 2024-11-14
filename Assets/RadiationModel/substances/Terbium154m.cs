using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium154m";
        public override double halfLife { get; } = 77400.0d;
        public override double atomicWeight { get; } = 153.92482d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3676400.0), new Gadolinium154() } },

        };
    }
}
    
    