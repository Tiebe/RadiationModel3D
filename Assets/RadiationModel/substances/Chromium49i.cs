using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium49i : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium49i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 48.95645d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00026, 4764400.0), new Chromium49() } },

        };
    }
}
    
    