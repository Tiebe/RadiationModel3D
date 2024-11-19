using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth204m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth204m";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 203.9787d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00154, 805000.0), new Bismuth204() } },

        };
    }
}
    
    