using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium257 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium257";
        public override double halfLife { get; } = 665280.0d;
        public override double atomicWeight { get; } = 257.09597d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 810000.0), new Fermium257() } },

        };
    }
}
    
    