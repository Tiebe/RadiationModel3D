using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium115 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium115";
        public override double halfLife { get; } = 1.03d;
        public override double atomicWeight { get; } = 114.92031d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6197000.0), new Palladium115() } },

        };
    }
}
    
    