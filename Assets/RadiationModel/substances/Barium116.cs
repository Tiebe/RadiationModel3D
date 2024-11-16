using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium116 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium116";
        public override double halfLife { get; } = 1.3d;
        public override double atomicWeight { get; } = 115.94162d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7660000.0), new Cesium116() } },

        };
    }
}
    
    