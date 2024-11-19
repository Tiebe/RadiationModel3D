using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium265m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium265m";
        public override double halfLife { get; } = 16.4d;
        public override double atomicWeight { get; } = 265.12109d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5d, new List<RadioactiveSubstance> { new AlphaParticle(10067002.09), new Rutherfordium261() } },

        };
    }
}
    
    