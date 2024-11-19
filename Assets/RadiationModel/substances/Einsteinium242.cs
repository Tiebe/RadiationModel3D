using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium242 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium242";
        public override double halfLife { get; } = 17.8d;
        public override double atomicWeight { get; } = 242.06957d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new List<RadioactiveSubstance> { new AlphaParticle(9177002.09), new Berkelium238() } },
            { 0.43d, new List<RadioactiveSubstance> { new BetaParticle(1, 5413000.0), new Californium242() } },

        };
    }
}
    
    