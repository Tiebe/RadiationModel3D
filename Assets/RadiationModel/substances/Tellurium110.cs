using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium110";
        public override double halfLife { get; } = 18.6d;
        public override double atomicWeight { get; } = 109.92246d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5220000.0), new Antimony110() } },

        };
    }
}
    
    