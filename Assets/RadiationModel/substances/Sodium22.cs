
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Sodium22 : RadioactiveSubstance
    {
        public override string name { get; } = "Sodium22";
        public override double halfLife { get; } = 82108033.4088d;
        public override double atomicWeight { get; } = 21.99444d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon22() } },

            { 0.9057d, new List<RadioactiveSubstance> { new BetaParticle(), new Neon22() } },

            { 0.0943d, new List<RadioactiveSubstance> { new Neon22() } },

        };
    }
}
    
    