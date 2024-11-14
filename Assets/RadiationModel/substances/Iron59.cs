using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron59 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron59";
        public override double halfLife { get; } = 3844800.0d;
        public override double atomicWeight { get; } = 58.93487d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1564800.0), new Cobalt59() } },

        };
    }
}
    
    