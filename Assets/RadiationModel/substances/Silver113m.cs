
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver113m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver113m";
        public override double halfLife { get; } = 68.7d;
        public override double atomicWeight { get; } = 112.90662d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.64d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver113() } },

            { 0.36d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium113() } },

        };
    }
}
    
    