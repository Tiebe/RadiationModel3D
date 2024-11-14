using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium163 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium163";
        public override double halfLife { get; } = 68.0d;
        public override double atomicWeight { get; } = 162.9341d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3207400.0), new Terbium163() } },

        };
    }
}
    
    