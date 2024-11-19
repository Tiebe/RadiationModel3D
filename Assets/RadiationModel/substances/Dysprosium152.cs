using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium152";
        public override double halfLife { get; } = 8568.0d;
        public override double atomicWeight { get; } = 151.92473d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9990000000000001d, new List<RadioactiveSubstance> { new Terbium152() } },
            { 0.001d, new List<RadioactiveSubstance> { new AlphaParticle(4748402.09), new Gadolinium148() } },

        };
    }
}
    
    