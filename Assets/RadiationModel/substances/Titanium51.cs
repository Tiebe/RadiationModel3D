using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium51 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium51";
        public override double halfLife { get; } = 345.6d;
        public override double atomicWeight { get; } = 50.94661d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2470110.0), new Vanadium51() } },

        };
    }
}
    
    