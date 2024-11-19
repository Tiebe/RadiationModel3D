using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth213 : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth213";
        public override double halfLife { get; } = 2736.0d;
        public override double atomicWeight { get; } = 212.99438d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9791d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1422000.0), new Polonium213() } },
            { 0.0209d, new List<RadioactiveSubstance> { new AlphaParticle(7010002.09), new Thallium209() } },

        };
    }
}
    
    