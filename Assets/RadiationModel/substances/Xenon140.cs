using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon140 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon140";
        public override double halfLife { get; } = 13.6d;
        public override double atomicWeight { get; } = 139.92165d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4063500.0), new Cesium140() } },

        };
    }
}
    
    