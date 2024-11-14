using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Promethium156 : RadioactiveSubstance
    {
        public override string name { get; } = "Promethium156";
        public override double halfLife { get; } = 27.4d;
        public override double atomicWeight { get; } = 155.93111d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5194200.0), new Samarium156() } },

        };
    }
}
    
    