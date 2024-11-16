using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mendelevium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Mendelevium253";
        public override double halfLife { get; } = 720.0d;
        public override double atomicWeight { get; } = 253.08714d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1824500.0), new Fermium253() } },
            { 0.006999999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(8587002.09), new Einsteinium249() } },

        };
    }
}
    
    