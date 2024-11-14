using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt72m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt72m";
        public override double halfLife { get; } = 0.0478d;
        public override double atomicWeight { get; } = 71.95695d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 14126100.0), new Nickel72() } },

        };
    }
}
    
    