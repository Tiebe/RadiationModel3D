using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver122m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver122m";
        public override double halfLife { get; } = 0.55d;
        public override double atomicWeight { get; } = 121.92375d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9582400.0), new Cadmium122() } },

        };
    }
}
    
    