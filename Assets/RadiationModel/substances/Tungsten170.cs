using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten170 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten170";
        public override double halfLife { get; } = 145.2d;
        public override double atomicWeight { get; } = 169.94923d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2847000.0), new Tantalum170() } },

        };
    }
}
    
    