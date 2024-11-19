using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Platinum167 : RadioactiveSubstance
    {
        public override string name { get; } = "Platinum167";
        public override double halfLife { get; } = 0.00092d;
        public override double atomicWeight { get; } = 166.99275d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8187002.09), new Osmium163() } },

        };
    }
}
    
    