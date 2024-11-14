using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium96";
        public override double halfLife { get; } = 594.0d;
        public override double atomicWeight { get; } = 95.91445d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6392390.0), new Ruthenium96() } },

        };
    }
}
    
    