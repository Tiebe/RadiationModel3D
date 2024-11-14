using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon19 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon19";
        public override double halfLife { get; } = 17.2569d;
        public override double atomicWeight { get; } = 19.00188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3239495.1), new Fluorine19() } },

        };
    }
}
    
    