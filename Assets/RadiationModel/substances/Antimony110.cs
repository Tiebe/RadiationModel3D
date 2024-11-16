using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony110 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony110";
        public override double halfLife { get; } = 23.6d;
        public override double atomicWeight { get; } = 109.91685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8392000.0), new Tin110() } },

        };
    }
}
    
    