using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon125 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon125";
        public override double halfLife { get; } = 60732.0d;
        public override double atomicWeight { get; } = 124.90639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1636600.0), new Iodine125() } },

        };
    }
}
    
    