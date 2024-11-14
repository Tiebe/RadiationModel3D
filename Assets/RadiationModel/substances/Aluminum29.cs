using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Aluminum29 : RadioactiveSubstance
    {
        public override string name { get; } = "Aluminum29";
        public override double halfLife { get; } = 393.6d;
        public override double atomicWeight { get; } = 28.98045d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3687281.5), new Silicon29() } },

        };
    }
}
    
    