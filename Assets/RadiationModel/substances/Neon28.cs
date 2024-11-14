using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon28 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon28";
        public override double halfLife { get; } = 0.0188d;
        public override double atomicWeight { get; } = 28.01213d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 12288000.0), new Sodium28() } },

        };
    }
}
    
    