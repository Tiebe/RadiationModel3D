using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium81 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium81";
        public override double halfLife { get; } = 70.4d;
        public override double atomicWeight { get; } = 80.92945d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5815000.0), new Strontium81() } },

        };
    }
}
    
    