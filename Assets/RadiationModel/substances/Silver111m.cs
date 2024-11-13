
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver111m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver111m";
        public override double halfLife { get; } = 64.8d;
        public override double atomicWeight { get; } = 110.90536d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.993d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver111() } },

            { 0.006999999999999999d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium111() } },

        };
    }
}
    
    