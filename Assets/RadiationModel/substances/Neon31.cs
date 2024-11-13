
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neon31 : RadioactiveSubstance
    {
        public override string name { get; } = "Neon31";
        public override double halfLife { get; } = 0.0034d;
        public override double atomicWeight { get; } = 31.03347d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Sodium31() } },

        };
    }
}
    
    