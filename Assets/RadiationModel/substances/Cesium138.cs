
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium138 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium138";
        public override double halfLife { get; } = 2010.0d;
        public override double atomicWeight { get; } = 137.91102d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium138() } },

        };
    }
}
    
    