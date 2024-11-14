using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium117m";
        public override double halfLife { get; } = 6.5d;
        public override double atomicWeight { get; } = 116.92878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7845000.0), new Xenon117() } },

        };
    }
}
    
    