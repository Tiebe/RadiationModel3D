using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium150 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium150";
        public override double halfLife { get; } = 12528.0d;
        public override double atomicWeight { get; } = 149.92366d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4658000.0), new Gadolinium150() } },

        };
    }
}
    
    