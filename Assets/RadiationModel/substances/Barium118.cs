
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium118 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium118";
        public override double halfLife { get; } = 5.2d;
        public override double atomicWeight { get; } = 117.93323d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium118() } },

        };
    }
}
    
    