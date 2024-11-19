using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium265m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium265m";
        public override double halfLife { get; } = 0.00036d;
        public override double atomicWeight { get; } = 265.13004d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11722002.09), new Seaborgium261() } },

        };
    }
}
    
    