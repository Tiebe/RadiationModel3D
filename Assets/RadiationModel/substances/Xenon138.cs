
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon138 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon138";
        public override double halfLife { get; } = 848.4d;
        public override double atomicWeight { get; } = 137.91415d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium138() } },

        };
    }
}
    
    