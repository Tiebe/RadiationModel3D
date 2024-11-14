using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium27 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium27";
        public override double halfLife { get; } = 0.301d;
        public override double atomicWeight { get; } = 26.99408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9068590.0), new Magnesium27() } },

        };
    }
}
    
    