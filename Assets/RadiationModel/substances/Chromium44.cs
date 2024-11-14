using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium44 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium44";
        public override double halfLife { get; } = 0.0428d;
        public override double atomicWeight { get; } = 43.98559d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10388000.0), new Vanadium44() } },

        };
    }
}
    
    