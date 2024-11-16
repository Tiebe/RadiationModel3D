using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper80 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper80";
        public override double halfLife { get; } = 0.1133d;
        public override double atomicWeight { get; } = 79.96062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14968600.0), new Zinc80() } },

        };
    }
}
    
    