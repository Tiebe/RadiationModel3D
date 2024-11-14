using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium127 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium127";
        public override double halfLife { get; } = 22500.0d;
        public override double atomicWeight { get; } = 126.90742d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2081000.0), new Xenon127() } },

        };
    }
}
    
    