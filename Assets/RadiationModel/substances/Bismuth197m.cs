using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth197m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth197m";
        public override double halfLife { get; } = 302.4d;
        public override double atomicWeight { get; } = 196.97944d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.55d, new List<RadioactiveSubstance> { new AlphaParticle(6917047.4), new Thallium193() } },
            { 0.45d, new List<RadioactiveSubstance> { new BetaParticle(1, 5590000.0), new Lead197() } },

        };
    }
}
    
    