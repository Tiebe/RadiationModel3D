using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium167 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium167";
        public override double halfLife { get; } = 4.2d;
        public override double atomicWeight { get; } = 166.94549d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 5107100.0), new Terbium167() } },

        };
    }
}
    
    