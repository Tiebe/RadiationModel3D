using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium166 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium166";
        public override double halfLife { get; } = 5.1d;
        public override double atomicWeight { get; } = 165.94163d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3437900.0), new Terbium166() } },

        };
    }
}
    
    