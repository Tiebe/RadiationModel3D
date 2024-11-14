using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium140 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium140";
        public override double halfLife { get; } = 2.29d;
        public override double atomicWeight { get; } = 139.94581d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11302000.0), new Gadolinium140() } },
            { 0.03d, new List<RadioactiveSubstance> { new Gadolinium140() } },

        };
    }
}
    
    