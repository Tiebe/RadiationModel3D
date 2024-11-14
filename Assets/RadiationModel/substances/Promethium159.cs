using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium159";
        public override double halfLife { get; } = 1.49d;
        public override double atomicWeight { get; } = 158.93929d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5654000.0), new Samarium159() } },

        };
    }
}
    
    