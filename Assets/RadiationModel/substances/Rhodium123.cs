
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium123";
        public override double halfLife { get; } = 0.042d;
        public override double atomicWeight { get; } = 122.94719d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium123() } },

        };
    }
}
    
    