
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium115";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 114.93591d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon115() } },

        };
    }
}
    
    