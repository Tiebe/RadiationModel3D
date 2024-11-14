using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon35 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon35";
        public override double halfLife { get; } = 1.7756d;
        public override double atomicWeight { get; } = 34.97526d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5966230.0), new Chlorine35() } },

        };
    }
}
    
    