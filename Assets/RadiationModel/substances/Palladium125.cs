using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium125 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium125";
        public override double halfLife { get; } = 0.06d;
        public override double atomicWeight { get; } = 124.94207d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10560000.0), new Silver125() } },

        };
    }
}
    
    