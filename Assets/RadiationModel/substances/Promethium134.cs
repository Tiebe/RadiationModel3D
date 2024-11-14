using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium134 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium134";
        public override double halfLife { get; } = 22.0d;
        public override double atomicWeight { get; } = 133.92833d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8886000.0), new Neodymium134() } },

        };
    }
}
    
    