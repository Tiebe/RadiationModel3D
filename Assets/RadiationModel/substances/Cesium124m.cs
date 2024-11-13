
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium124m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium124m";
        public override double halfLife { get; } = 6.41d;
        public override double atomicWeight { get; } = 123.91274d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9989d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium124() } },

            { 0.0011d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon124() } },

        };
    }
}
    
    