using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium168";
        public override double halfLife { get; } = 2.1d;
        public override double atomicWeight { get; } = 167.9678d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.57d, new List<RadioactiveSubstance> { new BetaParticle(1, 5795000.0), new Rhenium168() } },
            { 0.43d, new List<RadioactiveSubstance> { new AlphaParticle(6838002.09), new Tungsten164() } },

        };
    }
}
    
    