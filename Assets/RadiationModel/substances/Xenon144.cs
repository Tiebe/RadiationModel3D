using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon144 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon144";
        public override double halfLife { get; } = 0.388d;
        public override double atomicWeight { get; } = 143.93895d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6399000.0), new Cesium144() } },

        };
    }
}
    
    