using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium264 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium264";
        public override double halfLife { get; } = 0.7d;
        public override double atomicWeight { get; } = 264.12836d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7d, new List<RadioactiveSubstance> { new AlphaParticle(11613002.09), new Seaborgium260() } },
            { 0.3d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    