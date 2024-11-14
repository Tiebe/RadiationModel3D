using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Praseodymium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Praseodymium146";
        public override double halfLife { get; } = 1445.4d;
        public override double atomicWeight { get; } = 145.91769d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4255900.0), new Neodymium146() } },

        };
    }
}
    
    