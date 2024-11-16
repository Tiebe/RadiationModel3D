using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium131 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium131";
        public override double halfLife { get; } = 1.2d;
        public override double atomicWeight { get; } = 130.94602d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9490000.0), new Promethium131() } },

        };
    }
}
    
    