
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon146 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon146";
        public override double halfLife { get; } = 0.146d;
        public override double atomicWeight { get; } = 145.94852d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium146() } },

        };
    }
}
    
    