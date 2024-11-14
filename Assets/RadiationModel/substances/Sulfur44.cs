using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sulfur44 : RadioactiveSubstance
    {
        public override string name { get; } = "Sulfur44";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 43.99012d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11276000.0), new Chlorine44() } },

        };
    }
}
    
    