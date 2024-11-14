using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium94 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium94";
        public override double halfLife { get; } = 9.1d;
        public override double atomicWeight { get; } = 93.92904d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6806000.0), new Rhodium94() } },

        };
    }
}
    
    