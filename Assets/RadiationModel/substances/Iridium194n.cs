using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium194n : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium194n";
        public override double halfLife { get; } = 14774400.0d;
        public override double atomicWeight { get; } = 193.96547d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2600100.0), new Platinum194() } },

        };
    }
}
    
    