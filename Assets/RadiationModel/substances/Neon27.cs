
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon27 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon27";
        public override double halfLife { get; } = 0.0309d;
        public override double atomicWeight { get; } = 27.00757d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sodium27() } },

        };
    }
}
    
    