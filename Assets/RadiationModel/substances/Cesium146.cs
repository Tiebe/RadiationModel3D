
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium146";
        public override double halfLife { get; } = 0.3216d;
        public override double atomicWeight { get; } = 145.94062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium146() } },

        };
    }
}
    
    