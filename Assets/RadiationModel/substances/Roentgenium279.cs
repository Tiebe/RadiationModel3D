using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Roentgenium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Roentgenium279";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 279.16288d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11545047.4), new Meitnerium275() } },

        };
    }
}
    
    