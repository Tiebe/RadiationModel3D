
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium122 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium122";
        public override double halfLife { get; } = 117.0d;
        public override double atomicWeight { get; } = 121.9199d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium122() } },

        };
    }
}
    
    