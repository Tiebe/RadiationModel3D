using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium269";
        public override double halfLife { get; } = 15.0d;
        public override double atomicWeight { get; } = 269.13365d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10297002.09), new Seaborgium265() } },

        };
    }
}
    
    