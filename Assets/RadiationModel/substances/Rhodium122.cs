using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium122";
        public override double halfLife { get; } = 0.051d;
        public override double atomicWeight { get; } = 121.9443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12736000.0), new Palladium122() } },

        };
    }
}
    
    