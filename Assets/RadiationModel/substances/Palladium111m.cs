using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium111m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium111m";
        public override double halfLife { get; } = 20026.8d;
        public override double atomicWeight { get; } = 110.90788d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.768d, new List<RadioactiveSubstance> { new GammaParticle((172200.0, 0.0072)), new Palladium111() } },
            { 0.23199999999999998d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2401700.0), new Silver111() } },

        };
    }
}
    
    