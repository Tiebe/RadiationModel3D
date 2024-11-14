using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt58n : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58n";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 57.93581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.02335), new Cobalt58() } },

        };
    }
}
    
    