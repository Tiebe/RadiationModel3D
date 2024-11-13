
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

            { 0.83d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon121() } },

            { 0.17d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium121() } },

        };
    }
}
    
    