using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rubidium79 : RadioactiveSubstance
    {
        public override string name { get; } = "Rubidium79";
        public override double halfLife { get; } = 1374.0d;
        public override double atomicWeight { get; } = 78.92399d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3639200.0), new Krypton79() } },

        };
    }
}
    
    