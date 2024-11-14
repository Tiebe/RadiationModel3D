using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony112 : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony112";
        public override double halfLife { get; } = 53.5d;
        public override double atomicWeight { get; } = 111.9124d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7056050.0), new Tin112() } },

        };
    }
}
    
    