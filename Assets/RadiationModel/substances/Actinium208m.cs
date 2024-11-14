using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium208m : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium208m";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 208.01209d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9246047.4), new Francium204() } },

        };
    }
}
    
    