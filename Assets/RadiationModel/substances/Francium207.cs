using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium207 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium207";
        public override double halfLife { get; } = 14.8d;
        public override double atomicWeight { get; } = 206.99694d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.95d, new List<RadioactiveSubstance> { new AlphaParticle(7909047.4), new Astatine203() } },

        };
    }
}
    
    