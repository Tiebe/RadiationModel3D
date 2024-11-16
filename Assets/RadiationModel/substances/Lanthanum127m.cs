using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lanthanum127m : RadioactiveSubstance
    {
        public override string name { get; } = "Lanthanum127m";
        public override double halfLife { get; } = 222.0d;
        public override double atomicWeight { get; } = 126.91639d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4936000.0), new Barium127() } },

        };
    }
}
    
    