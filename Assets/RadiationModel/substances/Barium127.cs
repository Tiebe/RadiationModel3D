using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium127";
        public override double halfLife { get; } = 762.0d;
        public override double atomicWeight { get; } = 126.91109d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3422000.0), new Cesium127() } },

        };
    }
}
    
    