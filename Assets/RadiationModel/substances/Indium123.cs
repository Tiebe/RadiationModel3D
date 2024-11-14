using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium123 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium123";
        public override double halfLife { get; } = 6.17d;
        public override double atomicWeight { get; } = 122.91044d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4385700.0), new Tin123() } },

        };
    }
}
    
    