using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium52i : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium52i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 51.9526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00011, 11264910.0), new Chromium52() } },

        };
    }
}
    
    