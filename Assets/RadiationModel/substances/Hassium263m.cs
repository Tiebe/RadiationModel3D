
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium263m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium263m";
        public override double halfLife { get; } = 0.001d;
        public override double atomicWeight { get; } = 263.12883d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Seaborgium259() } },

        };
    }
}
    
    