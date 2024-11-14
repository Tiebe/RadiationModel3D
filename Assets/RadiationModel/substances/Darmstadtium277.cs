using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium277";
        public override double halfLife { get; } = 0.006d;
        public override double atomicWeight { get; } = 277.15576d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11915047.4), new Hassium273() } },

        };
    }
}
    
    