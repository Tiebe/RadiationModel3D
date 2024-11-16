using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium246";
        public override double halfLife { get; } = 155520.0d;
        public override double atomicWeight { get; } = 246.06867d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1353100.0), new Curium246() } },

        };
    }
}
    
    