using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium83 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium83";
        public override double halfLife { get; } = 424.8d;
        public override double atomicWeight { get; } = 82.92248d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4592000.0), new Strontium83() } },

        };
    }
}
    
    