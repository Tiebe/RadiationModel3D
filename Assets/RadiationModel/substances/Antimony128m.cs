using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony128m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony128m";
        public override double halfLife { get; } = 624.6d;
        public override double atomicWeight { get; } = 127.90916d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9640000000000001d, new List<RadioactiveSubstance> { new BetaParticle(-1, 4373800.0), new Tellurium128() } },
            { 0.036000000000000004d, new List<RadioactiveSubstance> { new GammaParticle(0.12398), new Antimony128() } },

        };
    }
}
    
    