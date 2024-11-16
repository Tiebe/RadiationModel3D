using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium105";
        public override double halfLife { get; } = 3330.0d;
        public override double atomicWeight { get; } = 104.90946d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2737200.0), new Silver105() } },

        };
    }
}
    
    