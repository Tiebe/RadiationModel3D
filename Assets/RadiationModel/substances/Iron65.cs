using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron65 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron65";
        public override double halfLife { get; } = 0.805d;
        public override double atomicWeight { get; } = 64.94502d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7967200.0), new Cobalt65() } },

        };
    }
}
    
    