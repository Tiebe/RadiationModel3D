using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium159m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium159m";
        public override double halfLife { get; } = 8.3d;
        public override double atomicWeight { get; } = 158.92794d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((206000.0, 0.00602)), new Holmium159() } },

        };
    }
}
    
    