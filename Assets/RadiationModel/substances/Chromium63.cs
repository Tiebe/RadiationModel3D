using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium63 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium63";
        public override double halfLife { get; } = 0.129d;
        public override double atomicWeight { get; } = 62.96116d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10707000.0), new Manganese63() } },

        };
    }
}
    
    