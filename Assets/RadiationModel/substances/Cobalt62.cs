using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt62 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt62";
        public override double halfLife { get; } = 92.4d;
        public override double atomicWeight { get; } = 61.93406d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5322400.0), new Nickel62() } },

        };
    }
}
    
    