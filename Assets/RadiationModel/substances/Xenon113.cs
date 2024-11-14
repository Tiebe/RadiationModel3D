using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon113 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon113";
        public override double halfLife { get; } = 2.74d;
        public override double atomicWeight { get; } = 112.93322d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8916000.0), new Iodine113() } },

        };
    }
}
    
    