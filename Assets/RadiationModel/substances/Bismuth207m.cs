using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth207m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth207m";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 206.98073d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2101599.99999, 0.00059)), new Bismuth207() } },

        };
    }
}
    
    