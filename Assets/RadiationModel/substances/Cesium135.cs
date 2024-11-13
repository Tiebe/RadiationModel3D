
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cesium135 : RadioactiveSubstance
    {
        public override string name { get; } = "Cesium135";
        public override double halfLife { get; } = 41970746160000.0d;
        public override double atomicWeight { get; } = 134.90598d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Barium135() } },

        };
    }
}
    
    