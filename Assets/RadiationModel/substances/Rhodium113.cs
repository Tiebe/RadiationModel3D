using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium113";
        public override double halfLife { get; } = 2.8d;
        public override double atomicWeight { get; } = 112.91544d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4823000.0), new Palladium113() } },

        };
    }
}
    
    