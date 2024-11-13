
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium141";
        public override double halfLife { get; } = 0.9d;
        public override double atomicWeight { get; } = 140.95128d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Terbium141() } },

        };
    }
}
    
    