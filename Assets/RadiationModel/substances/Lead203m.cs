using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead203m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead203m";
        public override double halfLife { get; } = 6.21d;
        public override double atomicWeight { get; } = 202.97428d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0015), new Lead203() } },

        };
    }
}
    
    