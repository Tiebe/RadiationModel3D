using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine22 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine22";
        public override double halfLife { get; } = 4.23d;
        public override double atomicWeight { get; } = 22.003d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10817716.0), new Neon22() } },

        };
    }
}
    
    