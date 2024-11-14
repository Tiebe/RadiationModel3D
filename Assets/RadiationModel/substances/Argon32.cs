using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Argon32 : RadioactiveSubstance
    {
        public override string name { get; } = "Argon32";
        public override double halfLife { get; } = 0.098d;
        public override double atomicWeight { get; } = 31.99764d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 11134300.0), new Chlorine32() } },

        };
    }
}
    
    