using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium98";
        public override double halfLife { get; } = 0.653d;
        public override double atomicWeight { get; } = 97.92869d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5867000.0), new Yttrium98() } },

        };
    }
}
    
    