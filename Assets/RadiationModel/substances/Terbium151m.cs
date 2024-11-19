using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium151m";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 150.92322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.934d, new List<RadioactiveSubstance> { new GammaParticle((100000.0, 0.0124)), new Terbium151() } },
            { 0.066d, new List<RadioactiveSubstance> { new BetaParticle(1, 2664900.0), new Gadolinium151() } },

        };
    }
}
    
    