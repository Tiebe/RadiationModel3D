using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium282 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium282";
        public override double halfLife { get; } = 0.1d;
        public override double atomicWeight { get; } = 282.16689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9685047.4), new Bohrium278() } },

        };
    }
}
    
    