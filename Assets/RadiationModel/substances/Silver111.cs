
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver111 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver111";
        public override double halfLife { get; } = 642211.2d;
        public override double atomicWeight { get; } = 110.9053d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium111() } },

        };
    }
}
    
    