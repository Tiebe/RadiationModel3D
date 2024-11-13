
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium122n : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium122n";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 121.91626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Xenon122() } },

        };
    }
}
    
    