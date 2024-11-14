using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine32 : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine32";
        public override double halfLife { get; } = 0.298d;
        public override double atomicWeight { get; } = 31.98568d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 12680837.100000001), new Sulfur32() } },

        };
    }
}
    
    