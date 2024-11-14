using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium172 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium172";
        public override double halfLife { get; } = 55.0d;
        public override double atomicWeight { get; } = 171.95537d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7527000.0), new Tungsten172() } },

        };
    }
}
    
    