using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nitrogen13 : RadioactiveSubstance
    {
        public override string name { get; } = "Nitrogen13";
        public override double halfLife { get; } = 597.9d;
        public override double atomicWeight { get; } = 13.00574d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2220470.6999999997), new Carbon13() } },

        };
    }
}
    
    