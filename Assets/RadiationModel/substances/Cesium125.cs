
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium125";
        public override double halfLife { get; } = 2661.0d;
        public override double atomicWeight { get; } = 124.90973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon125() } },

        };
    }
}
    
    