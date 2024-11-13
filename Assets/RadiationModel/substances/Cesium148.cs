
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium148 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium148";
        public override double halfLife { get; } = 0.1518d;
        public override double atomicWeight { get; } = 147.94964d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium148() } },

        };
    }
}
    
    