using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium152";
        public override double halfLife { get; } = 63000.0d;
        public override double atomicWeight { get; } = 151.92408d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3987300.0), new Gadolinium152() } },

        };
    }
}
    
    