using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium96";
        public override double halfLife { get; } = 122.0d;
        public override double atomicWeight { get; } = 95.91821d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3505000.0), new Rhodium96() } },

        };
    }
}
    
    