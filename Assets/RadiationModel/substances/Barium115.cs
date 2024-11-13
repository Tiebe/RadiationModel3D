
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium115";
        public override double halfLife { get; } = 0.45d;
        public override double atomicWeight { get; } = 114.94748d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium115() } },

        };
    }
}
    
    