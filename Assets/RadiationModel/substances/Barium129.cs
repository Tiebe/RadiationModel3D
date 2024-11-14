using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium129 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium129";
        public override double halfLife { get; } = 8028.0d;
        public override double atomicWeight { get; } = 128.90868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2438000.0), new Cesium129() } },

        };
    }
}
    
    