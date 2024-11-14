using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium138m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 137.94264d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00056), new Gadolinium138() } },

        };
    }
}
    
    