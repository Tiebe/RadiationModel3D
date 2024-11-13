
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium138m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium138m";
        public override double halfLife { get; } = 174.6d;
        public override double atomicWeight { get; } = 137.9111d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.81d, new List<RadioactiveSubstance> { new GammaParticle(), new Cesium138() } },

            { 0.19d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium138() } },

        };
    }
}
    
    