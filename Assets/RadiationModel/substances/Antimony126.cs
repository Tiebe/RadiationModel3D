using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony126 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony126";
        public override double halfLife { get; } = 1067040.0d;
        public override double atomicWeight { get; } = 125.90726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3674200.0), new Tellurium126() } },

        };
    }
}
    
    