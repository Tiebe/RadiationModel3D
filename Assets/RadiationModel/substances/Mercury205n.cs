using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury205n : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury205n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 204.97963d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((3317000.0, 0.00037)), new Mercury205() } },

        };
    }
}
    
    