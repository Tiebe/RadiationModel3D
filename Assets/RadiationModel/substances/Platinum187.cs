using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum187 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum187";
        public override double halfLife { get; } = 8460.0d;
        public override double atomicWeight { get; } = 186.96062d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2864000.0), new Iridium187() } },

        };
    }
}
    
    