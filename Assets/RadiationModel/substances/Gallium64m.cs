using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium64m : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium64m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 63.93689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((42800.0, 0.02897)), new Gallium64() } },

        };
    }
}
    
    