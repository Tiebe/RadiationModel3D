using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium97 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium97";
        public override double halfLife { get; } = 186.0d;
        public override double atomicWeight { get; } = 96.91647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4794000.0), new Rhodium97() } },

        };
    }
}
    
    