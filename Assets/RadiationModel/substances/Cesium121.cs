
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium121";
        public override double halfLife { get; } = 155.0d;
        public override double atomicWeight { get; } = 120.91723d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon121() } },

        };
    }
}
    
    