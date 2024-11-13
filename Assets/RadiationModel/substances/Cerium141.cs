
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium141 : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium141";
        public override double halfLife { get; } = 2808432.0d;
        public override double atomicWeight { get; } = 140.90829d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Praseodymium141() } },

        };
    }
}
    
    