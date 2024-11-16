using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium147 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium147";
        public override double halfLife { get; } = 0.2305d;
        public override double atomicWeight { get; } = 146.94426d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8344000.0), new Barium147() } },

        };
    }
}
    
    