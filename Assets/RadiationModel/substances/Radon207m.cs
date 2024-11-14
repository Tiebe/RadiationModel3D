using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon207m : RadioactiveSubstance
    {
        public override string name { get; } = "Radon207m";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 206.9917d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00138), new Radon207() } },

        };
    }
}
    
    