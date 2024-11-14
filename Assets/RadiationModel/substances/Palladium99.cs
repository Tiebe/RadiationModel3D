using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium99 : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium99";
        public override double halfLife { get; } = 1284.0d;
        public override double atomicWeight { get; } = 98.91177d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3402000.0), new Rhodium99() } },

        };
    }
}
    
    