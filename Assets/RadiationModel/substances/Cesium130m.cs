
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium130m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium130m";
        public override double halfLife { get; } = 207.6d;
        public override double atomicWeight { get; } = 129.90688d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium130() } },

            { 0.0016d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon130() } },

        };
    }
}
    
    