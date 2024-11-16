using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead210 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead210";
        public override double halfLife { get; } = 700564334.4d;
        public override double atomicWeight { get; } = 209.98419d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 63500.0), new Bismuth210() } },
            { 1.9e-08d, new List<RadioactiveSubstance> { new AlphaParticle(4814602.09), new Mercury206() } },

        };
    }
}
    
    