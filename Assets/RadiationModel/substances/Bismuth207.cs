using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth207 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth207";
        public override double halfLife { get; } = 985208041.44d;
        public override double atomicWeight { get; } = 206.97847d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2397400.0), new Lead207() } },

        };
    }
}
    
    