using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth198n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth198n";
        public override double halfLife { get; } = 7.7d;
        public override double atomicWeight { get; } = 197.97978d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00231), new Bismuth198() } },

        };
    }
}
    
    