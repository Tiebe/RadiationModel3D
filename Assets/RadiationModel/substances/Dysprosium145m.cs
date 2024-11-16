using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium145m : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium145m";
        public override double halfLife { get; } = 14.1d;
        public override double atomicWeight { get; } = 144.9376d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8275000.0), new Terbium145() } },

        };
    }
}
    
    