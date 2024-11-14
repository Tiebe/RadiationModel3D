using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese49 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese49";
        public override double halfLife { get; } = 0.382d;
        public override double atomicWeight { get; } = 48.95961d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7712500.0), new Chromium49() } },

        };
    }
}
    
    