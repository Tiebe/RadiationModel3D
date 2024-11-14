using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver126m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver126m";
        public override double halfLife { get; } = 0.1084d;
        public override double atomicWeight { get; } = 125.93492d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11635700.0), new Cadmium126() } },

        };
    }
}
    
    