using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum143 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum143";
        public override double halfLife { get; } = 852.0d;
        public override double atomicWeight { get; } = 142.91608d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3435400.0), new Cerium143() } },

        };
    }
}
    
    