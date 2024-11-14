using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium88 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium88";
        public override double halfLife { get; } = 1066.8d;
        public override double atomicWeight { get; } = 87.91132d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5312629.0), new Strontium88() } },

        };
    }
}
    
    