using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium23 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium23";
        public override double halfLife { get; } = 11.3039d;
        public override double atomicWeight { get; } = 22.99412d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4056183.5), new Sodium23() } },

        };
    }
}
    
    