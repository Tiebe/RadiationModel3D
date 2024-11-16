using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Seaborgium263m : RadioactiveSubstance
    {
        public override string name { get; } = "Seaborgium263m";
        public override double halfLife { get; } = 0.42d;
        public override double atomicWeight { get; } = 263.11836d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(10475047.4), new Rutherfordium259() } },

        };
    }
}
    
    