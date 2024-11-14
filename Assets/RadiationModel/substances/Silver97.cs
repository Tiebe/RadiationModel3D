using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver97 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver97";
        public override double halfLife { get; } = 25.5d;
        public override double atomicWeight { get; } = 96.92388d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6902000.0), new Palladium97() } },

        };
    }
}
    
    