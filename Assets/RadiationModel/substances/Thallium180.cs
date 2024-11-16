using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium180";
        public override double halfLife { get; } = 1.09d;
        public override double atomicWeight { get; } = 179.98992d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.93d, new List<RadioactiveSubstance> { new BetaParticle(1, 10861000.0), new Mercury180() } },
            { 0.07d, new List<RadioactiveSubstance> { new AlphaParticle(7725047.4), new Gold176() } },

        };
    }
}
    
    