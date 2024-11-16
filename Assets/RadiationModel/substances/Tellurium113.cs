using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium113";
        public override double halfLife { get; } = 102.0d;
        public override double atomicWeight { get; } = 112.91589d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6070000.0), new Antimony113() } },

        };
    }
}
    
    