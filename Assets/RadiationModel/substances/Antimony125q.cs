using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony125q : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony125q";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 124.90791d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0005, 2471000.0), new Antimony125() } },

        };
    }
}
    
    