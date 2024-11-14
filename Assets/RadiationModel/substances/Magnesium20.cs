using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium20 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium20";
        public override double halfLife { get; } = 0.0904d;
        public override double atomicWeight { get; } = 20.01876d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10627200.0), new Sodium20() } },

        };
    }
}
    
    