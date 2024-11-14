using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium159 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium159";
        public override double halfLife { get; } = 66524.4d;
        public override double atomicWeight { get; } = 158.9264d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 970700.0), new Terbium159() } },

        };
    }
}
    
    