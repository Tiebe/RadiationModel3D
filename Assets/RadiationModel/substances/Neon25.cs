
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon25 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon25";
        public override double halfLife { get; } = 0.602d;
        public override double atomicWeight { get; } = 24.99781d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sodium25() } },

        };
    }
}
    
    