using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver95n : RadioactiveSubstance
    {
        public override string name { get; } = "Silver95n";
        public override double halfLife { get; } = 0.016d;
        public override double atomicWeight { get; } = 94.9384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00049), new Silver95() } },

        };
    }
}
    
    