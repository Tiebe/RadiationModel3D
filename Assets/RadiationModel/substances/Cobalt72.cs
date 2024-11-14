using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt72 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt72";
        public override double halfLife { get; } = 0.0515d;
        public override double atomicWeight { get; } = 71.95674d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 13926100.0), new Nickel72() } },

        };
    }
}
    
    