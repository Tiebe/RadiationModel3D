
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium142";
        public override double halfLife { get; } = 1.687d;
        public override double atomicWeight { get; } = 141.9243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium142() } },

        };
    }
}
    
    