using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium145";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 144.92872d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6527000.0), new Gadolinium145() } },

        };
    }
}
    
    