using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon10 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon10";
        public override double halfLife { get; } = 19.3011d;
        public override double atomicWeight { get; } = 10.01685d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3648059.0), new Boron10() } },

        };
    }
}
    
    