using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium124m : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium124m";
        public override double halfLife { get; } = 6.41d;
        public override double atomicWeight { get; } = 123.91274d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9989d, new List<RadioactiveSubstance> { new GammaParticle((463000.0, 0.00268)), new Cesium124() } },
            { 0.0011d, new List<RadioactiveSubstance> { new BetaParticle(1, 6389400.0), new Xenon124() } },

        };
    }
}
    
    