
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium114m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium114m";
        public override double halfLife { get; } = 1.85d;
        public override double atomicWeight { get; } = 113.91894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Palladium114() } },

        };
    }
}
    
    