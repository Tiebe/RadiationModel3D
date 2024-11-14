using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fermium255 : RadioactiveSubstance
    {
        public override string name { get; } = "Fermium255";
        public override double halfLife { get; } = 72252.0d;
        public override double atomicWeight { get; } = 255.08996d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8260047.399999999), new Californium251() } },
            { 2.4000000000000003e-07d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    