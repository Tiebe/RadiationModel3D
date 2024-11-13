
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Barium143 : RadioactiveSubstance
    {
        public override string name { get; } = "Barium143";
        public override double halfLife { get; } = 14.5d;
        public override double atomicWeight { get; } = 142.92063d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lanthanum143() } },

        };
    }
}
    
    