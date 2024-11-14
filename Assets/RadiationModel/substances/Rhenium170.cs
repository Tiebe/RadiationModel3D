using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium170";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 169.95823d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8387000.0), new Tungsten170() } },

        };
    }
}
    
    