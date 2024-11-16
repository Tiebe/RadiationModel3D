using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium117 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium117";
        public override double halfLife { get; } = 1.75d;
        public override double atomicWeight { get; } = 116.93831d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9030000.0), new Cesium117() } },

        };
    }
}
    
    