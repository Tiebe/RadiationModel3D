using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Phosphorus28 : RadioactiveSubstance
    {
        public override string name { get; } = "Phosphorus28";
        public override double halfLife { get; } = 0.2703d;
        public override double atomicWeight { get; } = 27.99233d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 14344897.1), new Silicon28() } },

        };
    }
}
    
    