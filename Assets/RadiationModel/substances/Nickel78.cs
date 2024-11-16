using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel78 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel78";
        public override double halfLife { get; } = 0.1222d;
        public override double atomicWeight { get; } = 77.96255d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9909000.0), new Copper78() } },

        };
    }
}
    
    