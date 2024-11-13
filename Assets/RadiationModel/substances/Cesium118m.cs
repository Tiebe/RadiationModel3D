
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium118m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium118m";
        public override double halfLife { get; } = 17.0d;
        public override double atomicWeight { get; } = 117.92667d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon118() } },

        };
    }
}
    
    