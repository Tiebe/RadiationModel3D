
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium172";
        public override double halfLife { get; } = 0.76d;
        public override double atomicWeight { get; } = 171.95739d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Dysprosium172() } },

        };
    }
}
    
    