using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium246";
        public override double halfLife { get; } = 450.0d;
        public override double atomicWeight { get; } = 246.07281d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9009999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 3729800.0), new Californium246() } },
            { 0.099d, new List<RadioactiveSubstance> { new AlphaParticle(8667002.09), new Berkelium242() } },

        };
    }
}
    
    