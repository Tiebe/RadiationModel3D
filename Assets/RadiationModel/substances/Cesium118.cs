using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium118";
        public override double halfLife { get; } = 14.0d;
        public override double atomicWeight { get; } = 117.92656d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9670000.0), new Xenon118() } },

        };
    }
}
    
    