using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony114m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony114m";
        public override double halfLife { get; } = 0.00022d;
        public override double atomicWeight { get; } = 113.90982d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0025, 495000.0), new Antimony114() } },

        };
    }
}
    
    