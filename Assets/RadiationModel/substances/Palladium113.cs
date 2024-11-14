using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium113";
        public override double halfLife { get; } = 93.0d;
        public override double atomicWeight { get; } = 112.91026d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3437000.0), new Silver113() } },

        };
    }
}
    
    