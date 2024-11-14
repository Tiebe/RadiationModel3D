using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum126 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum126";
        public override double halfLife { get; } = 54.0d;
        public override double atomicWeight { get; } = 125.91952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7700000.0), new Barium126() } },

        };
    }
}
    
    