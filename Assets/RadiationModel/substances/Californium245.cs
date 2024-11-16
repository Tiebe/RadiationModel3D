using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Californium245 : RadioactiveSubstance
    {
        public override string name { get; } = "Californium245";
        public override double halfLife { get; } = 2700.0d;
        public override double atomicWeight { get; } = 245.06805d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.647d, new List<RadioactiveSubstance> { new BetaParticle(1, 1571400.0), new Berkelium245() } },
            { 0.353d, new List<RadioactiveSubstance> { new AlphaParticle(8278447.399999999), new Curium241() } },

        };
    }
}
    
    