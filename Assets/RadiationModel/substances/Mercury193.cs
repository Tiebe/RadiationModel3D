using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury193 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury193";
        public override double halfLife { get; } = 13680.0d;
        public override double atomicWeight { get; } = 192.96665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2343000.0), new Gold193() } },

        };
    }
}
    
    