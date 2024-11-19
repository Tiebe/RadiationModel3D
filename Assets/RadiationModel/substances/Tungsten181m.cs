using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten181m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten181m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 180.94861d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00339, 365500.0), new Tungsten181() } },

        };
    }
}
    
    