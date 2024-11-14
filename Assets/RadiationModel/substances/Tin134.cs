using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin134 : RadioactiveSubstance
    {
        public override string name { get; } = "Tin134";
        public override double halfLife { get; } = 0.93d;
        public override double atomicWeight { get; } = 133.92868d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7585000.0), new Antimony134() } },

        };
    }
}
    
    