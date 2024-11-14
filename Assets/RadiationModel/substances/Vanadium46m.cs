using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium46m : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium46m";
        public override double halfLife { get; } = 0.00102d;
        public override double atomicWeight { get; } = 45.96106d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00155), new Vanadium46() } },

        };
    }
}
    
    