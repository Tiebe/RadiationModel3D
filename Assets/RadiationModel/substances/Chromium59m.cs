using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium59m : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium59m";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 58.94889d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00247, 502700.0), new Chromium59() } },

        };
    }
}
    
    