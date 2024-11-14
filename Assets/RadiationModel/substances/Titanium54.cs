using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Titanium54 : RadioactiveSubstance
    {
        public override string name { get; } = "Titanium54";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 53.95089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4154000.0), new Vanadium54() } },

        };
    }
}
    
    