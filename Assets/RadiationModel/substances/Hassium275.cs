
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium275 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium275";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 275.14653d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Seaborgium271() } },

        };
    }
}
    
    