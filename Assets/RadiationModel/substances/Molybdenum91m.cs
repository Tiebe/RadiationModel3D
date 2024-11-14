using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum91m : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum91m";
        public override double halfLife { get; } = 64.6d;
        public override double atomicWeight { get; } = 90.91245d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.5d, new List<RadioactiveSubstance> { new GammaParticle(0.0019), new Molybdenum91() } },
            { 0.5d, new List<RadioactiveSubstance> { new BetaParticle(1, 5082000.0), new Niobium91() } },

        };
    }
}
    
    