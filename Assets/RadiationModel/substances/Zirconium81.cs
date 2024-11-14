using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium81";
        public override double halfLife { get; } = 5.5d;
        public override double atomicWeight { get; } = 80.93825d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8193000.0), new Yttrium81() } },

        };
    }
}
    
    