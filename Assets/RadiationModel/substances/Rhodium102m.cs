using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhodium102m : RadioactiveSubstance
    {
        public override string name { get; } = "Rhodium102m";
        public override double halfLife { get; } = 118086114.384d;
        public override double atomicWeight { get; } = 101.90699d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2464400.0), new Ruthenium102() } },
            { 0.00233d, new List<RadioactiveSubstance> { new GammaParticle(0.00879, 141000.0), new Rhodium102() } },

        };
    }
}
    
    