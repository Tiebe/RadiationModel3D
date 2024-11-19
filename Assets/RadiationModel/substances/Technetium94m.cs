using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium94m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium94m";
        public override double halfLife { get; } = 3120.0d;
        public override double atomicWeight { get; } = 93.90973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4332080.0), new Molybdenum94() } },
            { 0.0018d, new List<RadioactiveSubstance> { new GammaParticle(0.01631, 76000.0), new Technetium94() } },

        };
    }
}
    
    