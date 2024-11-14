using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium113 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium113";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 112.94443d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new ProtonParticle(), new Xenon112() } },

        };
    }
}
    
    