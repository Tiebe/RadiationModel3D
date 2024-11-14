using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ruthenium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Ruthenium123";
        public override double halfLife { get; } = 0.019d;
        public override double atomicWeight { get; } = 122.96076d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12640000.0), new Rhodium123() } },

        };
    }
}
    
    