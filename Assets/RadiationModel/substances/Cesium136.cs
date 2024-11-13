
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium136";
        public override double halfLife { get; } = 1124064.0d;
        public override double atomicWeight { get; } = 135.90731d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium136() } },

        };
    }
}
    
    