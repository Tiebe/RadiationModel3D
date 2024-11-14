using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium150";
        public override double halfLife { get; } = 0.081d;
        public override double atomicWeight { get; } = 149.95902d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11720000.0), new Barium150() } },

        };
    }
}
    
    