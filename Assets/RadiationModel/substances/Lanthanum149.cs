using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum149 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum149";
        public override double halfLife { get; } = 1.071d;
        public override double atomicWeight { get; } = 148.93535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6450000.0), new Cerium149() } },

        };
    }
}
    
    