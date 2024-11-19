using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium121m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium121m";
        public override double halfLife { get; } = 122.0d;
        public override double atomicWeight { get; } = 120.9173d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.83d, new List<RadioactiveSubstance> { new BetaParticle(1, 5447000.0), new Xenon121() } },
            { 0.17d, new List<RadioactiveSubstance> { new GammaParticle(0.01823, 68000.0), new Cesium121() } },

        };
    }
}
    
    