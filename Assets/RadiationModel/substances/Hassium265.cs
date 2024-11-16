using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium265 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium265";
        public override double halfLife { get; } = 0.00196d;
        public override double atomicWeight { get; } = 265.12979d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11490047.4), new Seaborgium261() } },

        };
    }
}
    
    