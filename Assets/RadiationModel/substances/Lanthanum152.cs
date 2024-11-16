using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum152 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum152";
        public override double halfLife { get; } = 0.287d;
        public override double atomicWeight { get; } = 151.94709d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9690000.0), new Cerium152() } },

        };
    }
}
    
    