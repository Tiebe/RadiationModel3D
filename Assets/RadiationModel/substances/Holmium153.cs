using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium153 : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium153";
        public override double halfLife { get; } = 120.6d;
        public override double atomicWeight { get; } = 152.93021d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99949d, new List<RadioactiveSubstance> { new BetaParticle(1, 4131000.0), new Dysprosium153() } },
            { 0.0005099999999999999d, new List<RadioactiveSubstance> { new AlphaParticle(5072047.4), new Terbium149() } },

        };
    }
}
    
    