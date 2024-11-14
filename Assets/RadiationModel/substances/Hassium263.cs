using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium263";
        public override double halfLife { get; } = 0.0009d;
        public override double atomicWeight { get; } = 263.12848d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11755047.4), new Seaborgium259() } },

        };
    }
}
    
    