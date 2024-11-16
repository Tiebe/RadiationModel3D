using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon24 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon24";
        public override double halfLife { get; } = 0.1432d;
        public override double atomicWeight { get; } = 24.01154d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10793810.0), new Aluminum24() } },

        };
    }
}
    
    