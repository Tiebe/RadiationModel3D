using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum123 : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum123";
        public override double halfLife { get; } = 17.0d;
        public override double atomicWeight { get; } = 122.9263d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 7005000.0), new Barium123() } },

        };
    }
}
    
    