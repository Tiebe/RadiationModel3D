using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury203 : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury203";
        public override double halfLife { get; } = 4027104.0d;
        public override double atomicWeight { get; } = 202.97287d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 492100.0), new Thallium203() } },

        };
    }
}
    
    