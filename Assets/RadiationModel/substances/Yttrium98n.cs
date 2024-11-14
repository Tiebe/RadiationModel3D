using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium98n : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium98n";
        public override double halfLife { get; } = 2.32d;
        public override double atomicWeight { get; } = 97.92289d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9459000.0), new Zirconium98() } },

        };
    }
}
    
    