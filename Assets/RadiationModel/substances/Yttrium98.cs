using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium98 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium98";
        public override double halfLife { get; } = 0.548d;
        public override double atomicWeight { get; } = 97.92239d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8993000.0), new Zirconium98() } },

        };
    }
}
    
    