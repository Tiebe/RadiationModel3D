using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium124";
        public override double halfLife { get; } = 30.9d;
        public override double atomicWeight { get; } = 123.91225d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5926400.0), new Xenon124() } },

        };
    }
}
    
    