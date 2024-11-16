using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon137 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon137";
        public override double halfLife { get; } = 229.08d;
        public override double atomicWeight { get; } = 136.91156d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4162390.0000000005), new Cesium137() } },

        };
    }
}
    
    