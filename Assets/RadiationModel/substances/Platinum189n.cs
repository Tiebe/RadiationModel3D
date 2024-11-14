using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum189n : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum189n";
        public override double halfLife { get; } = 0.00014d;
        public override double atomicWeight { get; } = 188.96105d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00649), new Platinum189() } },

        };
    }
}
    
    