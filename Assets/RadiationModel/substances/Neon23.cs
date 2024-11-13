
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon23 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon23";
        public override double halfLife { get; } = 37.15d;
        public override double atomicWeight { get; } = 22.99447d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sodium23() } },

        };
    }
}
    
    