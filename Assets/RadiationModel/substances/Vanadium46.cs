
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium46 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46";
        public override double halfLife { get; } = 0.42262d;
        public override double atomicWeight { get; } = 45.9602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Titanium46() } },

        };
    }
}
    
    