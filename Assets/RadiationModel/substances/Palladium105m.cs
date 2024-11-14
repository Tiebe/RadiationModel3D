using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium105m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium105m";
        public override double halfLife { get; } = 4e-05d;
        public override double atomicWeight { get; } = 104.9056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00253), new Palladium105() } },

        };
    }
}
    
    