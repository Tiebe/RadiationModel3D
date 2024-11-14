using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium125";
        public override double halfLife { get; } = 198.0d;
        public override double atomicWeight { get; } = 124.91447d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4421000.0), new Cesium125() } },

        };
    }
}
    
    