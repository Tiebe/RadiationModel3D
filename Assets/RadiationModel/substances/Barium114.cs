
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium114";
        public override double halfLife { get; } = 0.46d;
        public override double atomicWeight { get; } = 113.95071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium114() } },

            { 0.009000000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Xenon110() } },

            { 3.4e-05d, new List<RadioactiveSubstance> { new Carbon12(), new Tin102() } },

        };
    }
}
    
    