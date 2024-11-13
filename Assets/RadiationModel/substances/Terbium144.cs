
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium144 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium144";
        public override double halfLife { get; } = 1.0d;
        public override double atomicWeight { get; } = 143.93305d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Gadolinium144() } },

        };
    }
}
    
    