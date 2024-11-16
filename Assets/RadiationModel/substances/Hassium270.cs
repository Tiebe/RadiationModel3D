using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium270 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium270";
        public override double halfLife { get; } = 9.0d;
        public override double atomicWeight { get; } = 270.13431d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10087002.09), new Seaborgium266() } },

        };
    }
}
    
    