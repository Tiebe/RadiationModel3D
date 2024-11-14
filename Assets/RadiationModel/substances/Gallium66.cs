using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium66 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium66";
        public override double halfLife { get; } = 33494.4d;
        public override double atomicWeight { get; } = 65.93159d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5175500.0), new Zinc66() } },

        };
    }
}
    
    