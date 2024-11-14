using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium233 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium233";
        public override double halfLife { get; } = 1309.8d;
        public override double atomicWeight { get; } = 233.04158d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1242200.0), new Protactinium233() } },

        };
    }
}
    
    