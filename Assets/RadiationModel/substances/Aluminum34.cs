using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum34 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum34";
        public override double halfLife { get; } = 0.05373d;
        public override double atomicWeight { get; } = 33.99678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 16994100.0), new Silicon34() } },

        };
    }
}
    
    