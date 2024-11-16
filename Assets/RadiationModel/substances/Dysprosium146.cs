using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dysprosium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Dysprosium146";
        public override double halfLife { get; } = 33.2d;
        public override double atomicWeight { get; } = 145.93284d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5205000.0), new Terbium146() } },

        };
    }
}
    
    