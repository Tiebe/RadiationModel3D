
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium137 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium137";
        public override double halfLife { get; } = 947970838.08d;
        public override double atomicWeight { get; } = 136.90709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium137() } },

        };
    }
}
    
    