using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium152n : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium152n";
        public override double halfLife { get; } = 252.0d;
        public override double atomicWeight { get; } = 151.92462d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.789d, new List<RadioactiveSubstance> { new GammaParticle(0.00248), new Terbium152() } },
            { 0.21100000000000002d, new List<RadioactiveSubstance> { new BetaParticle(1, 4487300.0), new Gadolinium152() } },

        };
    }
}
    
    