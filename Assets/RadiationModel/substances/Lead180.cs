using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead180 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead180";
        public override double halfLife { get; } = 0.0041d;
        public override double atomicWeight { get; } = 179.99792d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8441002.09), new Mercury176() } },

        };
    }
}
    
    