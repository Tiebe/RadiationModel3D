using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten183m : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten183m";
        public override double halfLife { get; } = 5.3d;
        public override double atomicWeight { get; } = 182.95056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((309500.0, 0.00401)), new Tungsten183() } },

        };
    }
}
    
    