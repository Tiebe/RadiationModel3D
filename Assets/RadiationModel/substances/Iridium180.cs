using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium180 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium180";
        public override double halfLife { get; } = 90.0d;
        public override double atomicWeight { get; } = 179.95923d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6378000.0), new Osmium180() } },

        };
    }
}
    
    