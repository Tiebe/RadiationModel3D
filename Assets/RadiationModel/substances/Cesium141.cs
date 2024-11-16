using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium141";
        public override double halfLife { get; } = 24.84d;
        public override double atomicWeight { get; } = 140.92005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5255000.0), new Barium141() } },

        };
    }
}
    
    