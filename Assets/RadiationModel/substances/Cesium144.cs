using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium144";
        public override double halfLife { get; } = 0.994d;
        public override double atomicWeight { get; } = 143.93208d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8496000.0), new Barium144() } },

        };
    }
}
    
    