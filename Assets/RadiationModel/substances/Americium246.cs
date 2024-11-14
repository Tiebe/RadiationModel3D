using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Americium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Americium246";
        public override double halfLife { get; } = 2340.0d;
        public override double atomicWeight { get; } = 246.06977d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2377100.0), new Curium246() } },

        };
    }
}
    
    