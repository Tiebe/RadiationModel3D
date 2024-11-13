
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium119m";
        public override double halfLife { get; } = 30.4d;
        public override double atomicWeight { get; } = 118.92243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon119() } },

        };
    }
}
    
    