using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth215 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth215";
        public override double halfLife { get; } = 457.2d;
        public override double atomicWeight { get; } = 215.00175d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2170800.0), new Polonium215() } },

        };
    }
}
    
    