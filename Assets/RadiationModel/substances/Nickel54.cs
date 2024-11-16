using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel54 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel54";
        public override double halfLife { get; } = 0.1141d;
        public override double atomicWeight { get; } = 53.95783d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8732100.0), new Cobalt54() } },

        };
    }
}
    
    