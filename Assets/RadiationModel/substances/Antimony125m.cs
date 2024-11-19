using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony125m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony125m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 124.90737d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00063, 1971200.0), new Antimony125() } },

        };
    }
}
    
    