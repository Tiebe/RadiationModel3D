using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium132 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium132";
        public override double halfLife { get; } = 276825.6d;
        public override double atomicWeight { get; } = 131.90855d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 516000.0), new Iodine132() } },

        };
    }
}
    
    