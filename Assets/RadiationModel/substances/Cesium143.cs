
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium143";
        public override double halfLife { get; } = 1.802d;
        public override double atomicWeight { get; } = 142.92735d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium143() } },

        };
    }
}
    
    