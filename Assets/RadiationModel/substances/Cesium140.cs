
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium140";
        public override double halfLife { get; } = 63.7d;
        public override double atomicWeight { get; } = 139.91728d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium140() } },

        };
    }
}
    
    