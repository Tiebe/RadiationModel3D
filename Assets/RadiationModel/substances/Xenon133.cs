
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon133 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon133";
        public override double halfLife { get; } = 453375.36d;
        public override double atomicWeight { get; } = 132.90591d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium133() } },

        };
    }
}
    
    