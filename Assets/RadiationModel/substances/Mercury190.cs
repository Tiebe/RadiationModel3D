using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury190 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury190";
        public override double halfLife { get; } = 1200.0d;
        public override double atomicWeight { get; } = 189.96632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1463000.0), new Gold190() } },

        };
    }
}
    
    