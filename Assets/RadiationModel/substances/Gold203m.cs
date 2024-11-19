using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gold203m : RadioactiveSubstance
    {
        public override string name { get; } = "Gold203m";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 202.97584d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00193, 641000.0), new Gold203() } },

        };
    }
}
    
    