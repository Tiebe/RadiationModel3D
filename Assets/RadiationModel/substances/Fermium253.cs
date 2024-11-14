using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium253";
        public override double halfLife { get; } = 259200.0d;
        public override double atomicWeight { get; } = 253.08518d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> { new Einsteinium253() } },
            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(8217847.4), new Californium249() } },

        };
    }
}
    
    