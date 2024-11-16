using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth220 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth220";
        public override double halfLife { get; } = 9.5d;
        public override double atomicWeight { get; } = 220.0225d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5697000.0), new Polonium220() } },

        };
    }
}
    
    