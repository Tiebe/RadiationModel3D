using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium91 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium91";
        public override double halfLife { get; } = 34740.0d;
        public override double atomicWeight { get; } = 90.9102d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2699300.0), new Yttrium91() } },

        };
    }
}
    
    