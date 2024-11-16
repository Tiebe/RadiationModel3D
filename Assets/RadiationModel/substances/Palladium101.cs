using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium101 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium101";
        public override double halfLife { get; } = 30492.0d;
        public override double atomicWeight { get; } = 100.90828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1980000.0), new Rhodium101() } },

        };
    }
}
    
    