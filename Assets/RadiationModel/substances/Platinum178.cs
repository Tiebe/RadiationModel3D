using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum178 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum178";
        public override double halfLife { get; } = 20.7d;
        public override double atomicWeight { get; } = 177.96565d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9229999999999999d, new List<RadioactiveSubstance> { new BetaParticle(1, 4257000.0), new Iridium178() } },
            { 0.077d, new List<RadioactiveSubstance> { new AlphaParticle(6595002.09), new Osmium174() } },

        };
    }
}
    
    