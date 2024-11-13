
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium132";
        public override double halfLife { get; } = 559872.0d;
        public override double atomicWeight { get; } = 131.90644d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9813d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon132() } },

            { 0.0187d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium132() } },

        };
    }
}
    
    