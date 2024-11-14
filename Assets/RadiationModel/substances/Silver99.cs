using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver99 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver99";
        public override double halfLife { get; } = 124.2d;
        public override double atomicWeight { get; } = 98.91765d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5471000.0), new Palladium99() } },

        };
    }
}
    
    