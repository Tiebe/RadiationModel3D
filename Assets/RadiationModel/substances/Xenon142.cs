
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon142 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon142";
        public override double halfLife { get; } = 1.23d;
        public override double atomicWeight { get; } = 141.92997d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cesium142() } },

        };
    }
}
    
    