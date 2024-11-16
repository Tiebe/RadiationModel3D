using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium119 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium119";
        public override double halfLife { get; } = 5.4d;
        public override double atomicWeight { get; } = 118.93066d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7715000.0), new Cesium119() } },

        };
    }
}
    
    