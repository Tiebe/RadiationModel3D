using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium268 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium268";
        public override double halfLife { get; } = 1.4d;
        public override double atomicWeight { get; } = 268.13201d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10787002.09), new Seaborgium264() } },

        };
    }
}
    
    