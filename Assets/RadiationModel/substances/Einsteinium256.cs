using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Einsteinium256 : RadioactiveSubstance
    {
        public override string name { get; } = "Einsteinium256";
        public override double halfLife { get; } = 27360.0d;
        public override double atomicWeight { get; } = 256.0936d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1705000.0), new Fermium256() } },

        };
    }
}
    
    