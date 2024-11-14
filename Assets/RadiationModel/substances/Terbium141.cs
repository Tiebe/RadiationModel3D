using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium141";
        public override double halfLife { get; } = 3.5d;
        public override double atomicWeight { get; } = 140.94145d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8684000.0), new Gadolinium141() } },

        };
    }
}
    
    