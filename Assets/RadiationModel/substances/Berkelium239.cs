using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium239 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium239";
        public override double halfLife { get; } = 100.0d;
        public override double atomicWeight { get; } = 239.05824d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3100000.0), new Curium239() } },
            { 0.0001d, new List<RadioactiveSubstance> { new AlphaParticle(8225047.399999999), new Americium235() } },
            { 0.0001d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    