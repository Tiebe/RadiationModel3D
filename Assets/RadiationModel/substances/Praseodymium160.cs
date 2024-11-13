
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium160 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium160";
        public override double halfLife { get; } = 0.17d;
        public override double atomicWeight { get; } = 159.96114d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neodymium160() } },

        };
    }
}
    
    