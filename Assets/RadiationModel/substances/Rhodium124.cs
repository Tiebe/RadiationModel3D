using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium124 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium124";
        public override double halfLife { get; } = 0.03d;
        public override double atomicWeight { get; } = 123.952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13690000.0), new Palladium124() } },

        };
    }
}
    
    