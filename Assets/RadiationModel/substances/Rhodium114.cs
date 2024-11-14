using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium114 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium114";
        public override double halfLife { get; } = 1.85d;
        public override double atomicWeight { get; } = 113.91872d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7780000.0), new Palladium114() } },

        };
    }
}
    
    