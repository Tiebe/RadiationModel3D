using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium269 : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium269";
        public override double halfLife { get; } = 300.0d;
        public override double atomicWeight { get; } = 269.12849d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(9597002.09), new Rutherfordium265() } },

        };
    }
}
    
    