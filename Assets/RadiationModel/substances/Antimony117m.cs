using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony117m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony117m";
        public override double halfLife { get; } = 0.00036d;
        public override double atomicWeight { get; } = 116.9082d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0004), new Antimony117() } },

        };
    }
}
    
    