
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium136 : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium136";
        public override double halfLife { get; } = 3039.0d;
        public override double atomicWeight { get; } = 135.91498d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium136() } },

        };
    }
}
    
    