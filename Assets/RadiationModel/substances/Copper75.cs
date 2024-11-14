using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper75 : RadioactiveSubstance
    {
        public override string name { get; } = "Copper75";
        public override double halfLife { get; } = 1.224d;
        public override double atomicWeight { get; } = 74.94152d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8088700.0), new Zinc75() } },

        };
    }
}
    
    