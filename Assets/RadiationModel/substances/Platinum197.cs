using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum197 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum197";
        public override double halfLife { get; } = 71609.4d;
        public override double atomicWeight { get; } = 196.96734d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 720000.0), new Gold197() } },

        };
    }
}
    
    