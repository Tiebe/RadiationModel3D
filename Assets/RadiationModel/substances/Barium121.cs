using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium121 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium121";
        public override double halfLife { get; } = 29.7d;
        public override double atomicWeight { get; } = 120.92406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6362000.0), new Cesium121() } },

        };
    }
}
    
    