using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium137m : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium137m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 136.91128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00221, 561000.0), new Praseodymium137() } },

        };
    }
}
    
    