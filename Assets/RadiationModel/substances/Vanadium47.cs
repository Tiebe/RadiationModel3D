using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium47 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium47";
        public override double halfLife { get; } = 1956.0d;
        public override double atomicWeight { get; } = 46.9549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2930540.0), new Titanium47() } },

        };
    }
}
    
    