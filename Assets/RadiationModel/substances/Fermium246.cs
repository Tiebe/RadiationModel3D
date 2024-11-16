using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium246";
        public override double halfLife { get; } = 1.54d;
        public override double atomicWeight { get; } = 246.07535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.932d, new List<RadioactiveSubstance> { new AlphaParticle(9401002.09), new Californium242() } },
            { 0.068d, new List<RadioactiveSubstance> {  } },
            { 0.013000000000000001d, new List<RadioactiveSubstance> { new Einsteinium246() } },

        };
    }
}
    
    