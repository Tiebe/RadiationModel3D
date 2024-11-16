using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium244 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium244";
        public override double halfLife { get; } = 37.0d;
        public override double atomicWeight { get; } = 244.07089d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new List<RadioactiveSubstance> { new BetaParticle(1, 4551900.0), new Californium244() } },
            { 0.05d, new List<RadioactiveSubstance> { new AlphaParticle(8967002.09), new Berkelium240() } },

        };
    }
}
    
    