using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium109";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 108.9273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.961d, new List<RadioactiveSubstance> { new BetaParticle(1, 8536000.0), new Antimony109() } },
            { 0.039d, new List<RadioactiveSubstance> { new AlphaParticle(4218047.4), new Tin105() } },

        };
    }
}
    
    