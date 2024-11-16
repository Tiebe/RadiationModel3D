using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cerium127m : RadioactiveSubstance
    {
        public override string name { get; } = "Cerium127m";
        public override double halfLife { get; } = 28.6d;
        public override double atomicWeight { get; } = 126.92273d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5924000.0), new Lanthanum127() } },

        };
    }
}
    
    