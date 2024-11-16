using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum23 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum23";
        public override double halfLife { get; } = 0.446d;
        public override double atomicWeight { get; } = 23.00724d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12221770.0), new Magnesium23() } },

        };
    }
}
    
    