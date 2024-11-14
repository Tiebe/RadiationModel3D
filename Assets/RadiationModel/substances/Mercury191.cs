using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury191 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury191";
        public override double halfLife { get; } = 2940.0d;
        public override double atomicWeight { get; } = 190.96716d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3206000.0), new Gold191() } },

        };
    }
}
    
    