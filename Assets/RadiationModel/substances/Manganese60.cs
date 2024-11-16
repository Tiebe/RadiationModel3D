using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese60 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese60";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 59.94314d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8445100.0), new Iron60() } },

        };
    }
}
    
    