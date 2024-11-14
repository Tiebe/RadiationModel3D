using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt73 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt73";
        public override double halfLife { get; } = 0.042d;
        public override double atomicWeight { get; } = 72.95924d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12138200.0), new Nickel73() } },

        };
    }
}
    
    