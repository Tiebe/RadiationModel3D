using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton91 : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton91";
        public override double halfLife { get; } = 8.57d;
        public override double atomicWeight { get; } = 90.92381d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6771000.0), new Rubidium91() } },

        };
    }
}
    
    