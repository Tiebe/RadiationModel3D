using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth210 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth210";
        public override double halfLife { get; } = 433036.8d;
        public override double atomicWeight { get; } = 209.98412d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1161200.0), new Polonium210() } },
            { 1.32e-06d, new List<RadioactiveSubstance> { new AlphaParticle(6058402.09), new Thallium206() } },

        };
    }
}
    
    