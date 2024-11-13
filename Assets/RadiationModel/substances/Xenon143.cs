
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon143 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon143";
        public override double halfLife { get; } = 0.511d;
        public override double atomicWeight { get; } = 142.93537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium143() } },

        };
    }
}
    
    