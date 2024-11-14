using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony134 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony134";
        public override double halfLife { get; } = 0.674d;
        public override double atomicWeight { get; } = 133.92054d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8514800.0), new Tellurium134() } },

        };
    }
}
    
    