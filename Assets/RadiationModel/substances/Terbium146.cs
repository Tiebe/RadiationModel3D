using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium146 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium146";
        public override double halfLife { get; } = 8.0d;
        public override double atomicWeight { get; } = 145.92726d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8326000.0), new Gadolinium146() } },

        };
    }
}
    
    