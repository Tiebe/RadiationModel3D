
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon139 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon139";
        public override double halfLife { get; } = 39.68d;
        public override double atomicWeight { get; } = 138.91879d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium139() } },

        };
    }
}
    
    