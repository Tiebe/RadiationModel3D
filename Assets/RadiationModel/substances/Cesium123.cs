
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium123";
        public override double halfLife { get; } = 352.8d;
        public override double atomicWeight { get; } = 122.913d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon123() } },

        };
    }
}
    
    