using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony121m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony121m";
        public override double halfLife { get; } = 0.00018d;
        public override double atomicWeight { get; } = 120.90676d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00045, 2751200.0), new Antimony121() } },

        };
    }
}
    
    