using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium110";
        public override double halfLife { get; } = 3.35d;
        public override double atomicWeight { get; } = 109.91108d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5501900.0), new Palladium110() } },

        };
    }
}
    
    