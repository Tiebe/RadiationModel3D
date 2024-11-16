using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium95 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium95";
        public override double halfLife { get; } = 301.2d;
        public override double atomicWeight { get; } = 94.9159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5117000.0), new Ruthenium95() } },

        };
    }
}
    
    