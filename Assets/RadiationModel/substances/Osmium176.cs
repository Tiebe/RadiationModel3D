using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium176 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium176";
        public override double halfLife { get; } = 216.0d;
        public override double atomicWeight { get; } = 175.95477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2932000.0), new Rhenium176() } },

        };
    }
}
    
    