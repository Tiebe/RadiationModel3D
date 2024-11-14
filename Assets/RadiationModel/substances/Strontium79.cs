using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium79";
        public override double halfLife { get; } = 135.0d;
        public override double atomicWeight { get; } = 78.9297d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5322800.0), new Rubidium79() } },

        };
    }
}
    
    