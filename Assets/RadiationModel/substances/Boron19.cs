using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Boron19 : RadioactiveSubstance
    {
        public override string name { get; } = "Boron19";
        public override double halfLife { get; } = 0.00292d;
        public override double atomicWeight { get; } = 19.06417d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 27360000.0), new Carbon19() } },

        };
    }
}
    
    