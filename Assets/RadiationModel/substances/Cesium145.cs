
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium145 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium145";
        public override double halfLife { get; } = 0.582d;
        public override double atomicWeight { get; } = 144.93553d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium145() } },

        };
    }
}
    
    