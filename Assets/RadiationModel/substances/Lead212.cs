using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead212 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead212";
        public override double halfLife { get; } = 38257.2d;
        public override double atomicWeight { get; } = 211.9919d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 569000.0), new Bismuth212() } },

        };
    }
}
    
    