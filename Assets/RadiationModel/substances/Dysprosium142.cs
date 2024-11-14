using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium142";
        public override double halfLife { get; } = 2.3d;
        public override double atomicWeight { get; } = 141.94619d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6440000.0), new Terbium142() } },
            { 0.9d, new List<RadioactiveSubstance> { new BetaParticle(1, 6440000.0), new Terbium142() } },
            { 0.1d, new List<RadioactiveSubstance> { new Terbium142() } },

        };
    }
}
    
    