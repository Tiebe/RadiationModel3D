using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium250 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium250";
        public override double halfLife { get; } = 11563.2d;
        public override double atomicWeight { get; } = 250.07832d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1781700.0), new Californium250() } },

        };
    }
}
    
    