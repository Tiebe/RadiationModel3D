using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium243 : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium243";
        public override double halfLife { get; } = 16560.0d;
        public override double atomicWeight { get; } = 243.06301d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 1508100.0), new Curium243() } },
            { 0.0015d, new List<RadioactiveSubstance> { new AlphaParticle(7894647.399999999), new Americium239() } },

        };
    }
}
    
    