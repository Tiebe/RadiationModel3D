using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium149 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium149";
        public override double halfLife { get; } = 0.1123d;
        public override double atomicWeight { get; } = 148.95352d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9530600.0), new Barium149() } },

        };
    }
}
    
    