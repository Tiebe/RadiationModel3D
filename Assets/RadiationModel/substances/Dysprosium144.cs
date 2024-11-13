
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium144";
        public override double halfLife { get; } = 9.1d;
        public override double atomicWeight { get; } = 143.93927d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium144() } },

        };
    }
}
    
    