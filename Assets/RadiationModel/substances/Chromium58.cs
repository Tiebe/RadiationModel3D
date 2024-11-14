using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium58 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium58";
        public override double halfLife { get; } = 7.0d;
        public override double atomicWeight { get; } = 57.94418d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3835800.0), new Manganese58() } },

        };
    }
}
    
    