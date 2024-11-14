using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium266 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium266";
        public override double halfLife { get; } = 0.003d;
        public override double atomicWeight { get; } = 266.13005d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new List<RadioactiveSubstance> { new AlphaParticle(11366047.4), new Seaborgium262() } },
            { 0.24d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    