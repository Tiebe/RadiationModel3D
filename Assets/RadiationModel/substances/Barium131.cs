
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium131";
        public override double halfLife { get; } = 995328.0d;
        public override double atomicWeight { get; } = 130.90695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium131() } },

        };
    }
}
    
    