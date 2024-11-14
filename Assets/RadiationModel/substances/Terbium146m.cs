using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium146m : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium146m";
        public override double halfLife { get; } = 24.1d;
        public override double atomicWeight { get; } = 145.92742d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 8476000.0), new Gadolinium146() } },

        };
    }
}
    
    