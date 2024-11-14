using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium253 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium253";
        public override double halfLife { get; } = 1768608.0d;
        public override double atomicWeight { get; } = 253.08482d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7759247.4), new Berkelium249() } },
            { 8.7e-08d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    