using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium214m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium214m";
        public override double halfLife { get; } = 0.00335d;
        public override double atomicWeight { get; } = 213.9991d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9730047.4), new Astatine210() } },

        };
    }
}
    
    