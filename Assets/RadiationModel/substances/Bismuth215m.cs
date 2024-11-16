using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth215m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth215m";
        public override double halfLife { get; } = 36.9d;
        public override double atomicWeight { get; } = 215.00322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.769d, new List<RadioactiveSubstance> { new GammaParticle((1367000.0, 0.00091)), new Bismuth215() } },
            { 0.231d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3537800.0), new Polonium215() } },

        };
    }
}
    
    