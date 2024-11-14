using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon120 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon120";
        public override double halfLife { get; } = 2760.0d;
        public override double atomicWeight { get; } = 119.91178d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1575000.0), new Iodine120() } },

        };
    }
}
    
    