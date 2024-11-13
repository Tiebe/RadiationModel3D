
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese50 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese50";
        public override double halfLife { get; } = 0.28321d;
        public override double atomicWeight { get; } = 49.95424d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Chromium50() } },

        };
    }
}
    
    