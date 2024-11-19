using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium209 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium209";
        public override double halfLife { get; } = 3913062048.0d;
        public override double atomicWeight { get; } = 208.98243d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99546d, new List<RadioactiveSubstance> { new AlphaParticle(6001202.09), new Lead205() } },
            { 0.00454d, new List<RadioactiveSubstance> { new BetaParticle(1, 1892600.0), new Bismuth209() } },

        };
    }
}
    
    