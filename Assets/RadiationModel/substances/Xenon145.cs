using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon145 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon145";
        public override double halfLife { get; } = 0.188d;
        public override double atomicWeight { get; } = 144.94472d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8561000.0), new Cesium145() } },

        };
    }
}
    
    