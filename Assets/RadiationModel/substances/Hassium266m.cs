using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium266m : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium266m";
        public override double halfLife { get; } = 0.28d;
        public override double atomicWeight { get; } = 266.13123d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(12466047.4), new Seaborgium262() } },

        };
    }
}
    
    