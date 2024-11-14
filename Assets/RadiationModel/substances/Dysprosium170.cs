using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium170";
        public override double halfLife { get; } = 54.9d;
        public override double atomicWeight { get; } = 169.94234d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2530000.0), new Holmium170() } },

        };
    }
}
    
    