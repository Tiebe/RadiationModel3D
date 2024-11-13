
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chromium62 : RadioactiveSubstance
    {
        public override string name { get; } = "Chromium62";
        public override double halfLife { get; } = 0.206d;
        public override double atomicWeight { get; } = 61.95614d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Manganese62() } },

        };
    }
}
    
    