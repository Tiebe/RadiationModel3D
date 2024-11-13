
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon135m : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon135m";
        public override double halfLife { get; } = 917.4d;
        public override double atomicWeight { get; } = 134.9078d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Xenon135() } },

            { 0.003d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium135() } },

        };
    }
}
    
    