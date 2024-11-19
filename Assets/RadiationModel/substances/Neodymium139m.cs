using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium139m : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium139m";
        public override double halfLife { get; } = 19800.0d;
        public override double atomicWeight { get; } = 138.9122d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.87d, new List<RadioactiveSubstance> { new BetaParticle(1, 3043000.0), new Praseodymium139() } },
            { 0.13d, new List<RadioactiveSubstance> { new GammaParticle((231000.0, 0.00537)), new Neodymium139() } },

        };
    }
}
    
    