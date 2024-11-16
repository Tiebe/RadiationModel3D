using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium116";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 115.9334d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11007000.0), new Xenon116() } },

        };
    }
}
    
    