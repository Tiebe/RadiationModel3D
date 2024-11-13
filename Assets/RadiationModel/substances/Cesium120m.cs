
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium120m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium120m";
        public override double halfLife { get; } = 57.0d;
        public override double atomicWeight { get; } = 119.92078d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon120() } },

        };
    }
}
    
    