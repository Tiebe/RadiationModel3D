using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver106m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver106m";
        public override double halfLife { get; } = 715392.0d;
        public override double atomicWeight { get; } = 105.90676d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3055500.0), new Palladium106() } },

        };
    }
}
    
    