using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth194 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth194";
        public override double halfLife { get; } = 95.0d;
        public override double atomicWeight { get; } = 193.9828d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8185000.0), new Lead194() } },
            { 0.0046d, new List<RadioactiveSubstance> { new AlphaParticle(6940002.09), new Thallium190() } },

        };
    }
}
    
    