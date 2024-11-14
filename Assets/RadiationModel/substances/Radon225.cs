using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon225 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon225";
        public override double halfLife { get; } = 279.6d;
        public override double atomicWeight { get; } = 225.02849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2713000.0), new Francium225() } },

        };
    }
}
    
    