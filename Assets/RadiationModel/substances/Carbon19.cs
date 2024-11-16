using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon19 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon19";
        public override double halfLife { get; } = 0.0462d;
        public override double atomicWeight { get; } = 19.03479d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 16554000.0), new Nitrogen19() } },

        };
    }
}
    
    