using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium110 : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium110";
        public override double halfLife { get; } = 0.075d;
        public override double atomicWeight { get; } = 109.94384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12226000.0), new Molybdenum110() } },

        };
    }
}
    
    