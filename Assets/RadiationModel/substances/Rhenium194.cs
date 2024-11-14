using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium194";
        public override double halfLife { get; } = 5.0d;
        public override double atomicWeight { get; } = 193.97074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5175200.0), new Osmium194() } },

        };
    }
}
    
    