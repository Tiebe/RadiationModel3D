using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium194 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium194";
        public override double halfLife { get; } = 0.392d;
        public override double atomicWeight { get; } = 193.98819d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8009002.09), new Lead190() } },

        };
    }
}
    
    