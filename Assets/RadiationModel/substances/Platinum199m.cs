using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum199m : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum199m";
        public override double halfLife { get; } = 13.48d;
        public override double atomicWeight { get; } = 198.97105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00292, 424000.0), new Platinum199() } },

        };
    }
}
    
    