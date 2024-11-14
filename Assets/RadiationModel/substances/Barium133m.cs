using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium133m : RadioactiveSubstance
    {
        public override string name { get; } = "Barium133m";
        public override double halfLife { get; } = 140040.0d;
        public override double atomicWeight { get; } = 132.90632d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999896d, new List<RadioactiveSubstance> { new GammaParticle(0.0043), new Barium133() } },
            { 0.000104d, new List<RadioactiveSubstance> { new Cesium133() } },

        };
    }
}
    
    