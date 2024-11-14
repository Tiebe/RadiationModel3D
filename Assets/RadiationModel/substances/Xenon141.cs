using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon141 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon141";
        public override double halfLife { get; } = 1.73d;
        public override double atomicWeight { get; } = 140.92679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6279700.0), new Cesium141() } },

        };
    }
}
    
    