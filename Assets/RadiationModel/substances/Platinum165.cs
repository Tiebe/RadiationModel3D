using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum165 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum165";
        public override double halfLife { get; } = 0.00037d;
        public override double atomicWeight { get; } = 164.99966d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8477002.09), new Osmium161() } },

        };
    }
}
    
    