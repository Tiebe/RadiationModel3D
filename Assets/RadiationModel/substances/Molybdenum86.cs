using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum86 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum86";
        public override double halfLife { get; } = 19.1d;
        public override double atomicWeight { get; } = 85.93117d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5023100.0), new Niobium86() } },

        };
    }
}
    
    