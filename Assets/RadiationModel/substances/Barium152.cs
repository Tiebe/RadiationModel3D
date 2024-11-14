using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium152 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium152";
        public override double halfLife { get; } = 0.139d;
        public override double atomicWeight { get; } = 151.95533d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7680000.0), new Lanthanum152() } },

        };
    }
}
    
    