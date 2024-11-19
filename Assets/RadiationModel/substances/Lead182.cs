using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead182 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead182";
        public override double halfLife { get; } = 0.055d;
        public override double atomicWeight { get; } = 181.99267d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8087002.09), new Mercury178() } },

        };
    }
}
    
    