
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium117";
        public override double halfLife { get; } = 8.4d;
        public override double atomicWeight { get; } = 116.92862d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon117() } },

        };
    }
}
    
    