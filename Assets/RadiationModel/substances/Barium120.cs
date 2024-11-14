using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium120 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium120";
        public override double halfLife { get; } = 24.0d;
        public override double atomicWeight { get; } = 119.92604d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4999000.0), new Cesium120() } },

        };
    }
}
    
    