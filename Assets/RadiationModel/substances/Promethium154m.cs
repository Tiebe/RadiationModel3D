using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium154m : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium154m";
        public override double halfLife { get; } = 103.8d;
        public override double atomicWeight { get; } = 153.92647d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3965600.0), new Samarium154() } },

        };
    }
}
    
    