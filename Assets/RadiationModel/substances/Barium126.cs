using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium126 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium126";
        public override double halfLife { get; } = 6000.0d;
        public override double atomicWeight { get; } = 125.91125d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1681000.0), new Cesium126() } },

        };
    }
}
    
    