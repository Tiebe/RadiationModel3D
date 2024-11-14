using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium154 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium154";
        public override double halfLife { get; } = 35978.4d;
        public override double atomicWeight { get; } = 153.92468d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3546400.0), new Gadolinium154() } },

        };
    }
}
    
    