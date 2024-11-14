using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon147 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon147";
        public override double halfLife { get; } = 0.088d;
        public override double atomicWeight { get; } = 146.95448d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9520000.0), new Cesium147() } },

        };
    }
}
    
    