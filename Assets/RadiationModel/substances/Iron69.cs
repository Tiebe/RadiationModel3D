
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron69 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron69";
        public override double halfLife { get; } = 0.162d;
        public override double atomicWeight { get; } = 68.95792d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt69() } },

        };
    }
}
    
    