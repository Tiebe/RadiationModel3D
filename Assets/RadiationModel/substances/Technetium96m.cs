using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Technetium96m : RadioactiveSubstance
    {
        public override string name { get; } = "Technetium96m";
        public override double halfLife { get; } = 3090.0d;
        public override double atomicWeight { get; } = 95.9079d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.98d, new List<RadioactiveSubstance> { new GammaParticle(0.03647, 34000.0), new Technetium96() } },
            { 0.02d, new List<RadioactiveSubstance> { new BetaParticle(1, 3006890.0), new Molybdenum96() } },

        };
    }
}
    
    