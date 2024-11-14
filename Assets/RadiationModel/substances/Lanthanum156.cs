using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum156 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum156";
        public override double halfLife { get; } = 0.084d;
        public override double atomicWeight { get; } = 155.96452d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11770000.0), new Cerium156() } },

        };
    }
}
    
    