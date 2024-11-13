
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium139";
        public override double halfLife { get; } = 556.2d;
        public override double atomicWeight { get; } = 138.91336d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium139() } },

        };
    }
}
    
    