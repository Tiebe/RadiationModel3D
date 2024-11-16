using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony115 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony115";
        public override double halfLife { get; } = 1926.0d;
        public override double atomicWeight { get; } = 114.9066d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3030846.0), new Tin115() } },

        };
    }
}
    
    