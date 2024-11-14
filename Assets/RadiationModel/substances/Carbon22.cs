using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon22 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon22";
        public override double halfLife { get; } = 0.0062d;
        public override double atomicWeight { get; } = 22.05755d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 21850000.0), new Nitrogen22() } },

        };
    }
}
    
    