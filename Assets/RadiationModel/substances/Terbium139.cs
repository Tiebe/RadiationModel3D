using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium139 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium139";
        public override double halfLife { get; } = 1.6d;
        public override double atomicWeight { get; } = 138.94833d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 9500000.0), new Gadolinium139() } },

        };
    }
}
    
    