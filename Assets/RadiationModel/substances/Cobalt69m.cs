using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt69m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt69m";
        public override double halfLife { get; } = 0.75d;
        public override double atomicWeight { get; } = 68.94609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 9766000.0), new Nickel69() } },

        };
    }
}
    
    