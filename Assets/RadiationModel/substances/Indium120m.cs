using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium120m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium120m";
        public override double halfLife { get; } = 46.2d;
        public override double atomicWeight { get; } = 119.90802d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5417700.0), new Tin120() } },

        };
    }
}
    
    