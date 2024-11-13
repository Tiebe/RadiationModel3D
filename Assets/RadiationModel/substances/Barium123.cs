
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium123";
        public override double halfLife { get; } = 162.0d;
        public override double atomicWeight { get; } = 122.91878d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium123() } },

        };
    }
}
    
    