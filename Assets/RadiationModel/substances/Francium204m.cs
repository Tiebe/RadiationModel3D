using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium204m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium204m";
        public override double halfLife { get; } = 2.41d;
        public override double atomicWeight { get; } = 204.00071d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new AlphaParticle(8243002.09), new Astatine200() } },

        };
    }
}
    
    