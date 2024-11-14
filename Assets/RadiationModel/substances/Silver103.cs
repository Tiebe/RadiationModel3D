using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver103 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver103";
        public override double halfLife { get; } = 3942.0d;
        public override double atomicWeight { get; } = 102.90896d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2654000.0), new Palladium103() } },

        };
    }
}
    
    