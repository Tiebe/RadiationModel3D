using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium32 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium32";
        public override double halfLife { get; } = 0.0129d;
        public override double atomicWeight { get; } = 32.02001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 19469000.0), new Magnesium32() } },

        };
    }
}
    
    