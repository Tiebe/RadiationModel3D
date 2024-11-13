
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium134";
        public override double halfLife { get; } = 65165105.88d;
        public override double atomicWeight { get; } = 133.90672d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium134() } },

            { 2.9999999999999997e-06d, new List<RadioactiveSubstance> { new Xenon134() } },

        };
    }
}
    
    