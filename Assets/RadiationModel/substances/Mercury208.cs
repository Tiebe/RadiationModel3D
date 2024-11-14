using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury208 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury208";
        public override double halfLife { get; } = 135.0d;
        public override double atomicWeight { get; } = 207.98575d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3480100.0), new Thallium208() } },

        };
    }
}
    
    