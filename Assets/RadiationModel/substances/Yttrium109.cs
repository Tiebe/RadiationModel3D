using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium109";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 108.96513d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13250000.0), new Zirconium109() } },

        };
    }
}
    
    