
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine143 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine143";
        public override double halfLife { get; } = 0.182d;
        public override double atomicWeight { get; } = 142.94547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon143() } },

        };
    }
}
    
    