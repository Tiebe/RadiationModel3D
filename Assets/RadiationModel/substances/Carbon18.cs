using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon18 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon18";
        public override double halfLife { get; } = 0.092d;
        public override double atomicWeight { get; } = 18.02675d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 11807000.0), new Nitrogen18() } },

        };
    }
}
    
    