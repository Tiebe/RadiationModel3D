using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth187 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth187";
        public override double halfLife { get; } = 0.037d;
        public override double atomicWeight { get; } = 186.99315d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8801002.09), new Thallium183() } },

        };
    }
}
    
    