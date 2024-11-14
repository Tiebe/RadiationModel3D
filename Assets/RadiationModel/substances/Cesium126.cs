using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium126";
        public override double halfLife { get; } = 98.4d;
        public override double atomicWeight { get; } = 125.90945d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4795387.0), new Xenon126() } },

        };
    }
}
    
    