using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon148 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon148";
        public override double halfLife { get; } = 0.085d;
        public override double atomicWeight { get; } = 147.95851d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8261000.0), new Cesium148() } },

        };
    }
}
    
    