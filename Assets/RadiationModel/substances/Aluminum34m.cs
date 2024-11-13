
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum34m : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum34m";
        public override double halfLife { get; } = 0.0221d;
        public override double atomicWeight { get; } = 33.99683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Silicon34() } },

        };
    }
}
    
    