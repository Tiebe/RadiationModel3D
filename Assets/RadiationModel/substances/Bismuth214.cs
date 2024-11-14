using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth214 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth214";
        public override double halfLife { get; } = 1194.0d;
        public override double atomicWeight { get; } = 213.99871d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.99979d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3269000.0), new Polonium214() } },
            { 0.00021d, new List<RadioactiveSubstance> { new AlphaParticle(6641047.4), new Thallium210() } },

        };
    }
}
    
    