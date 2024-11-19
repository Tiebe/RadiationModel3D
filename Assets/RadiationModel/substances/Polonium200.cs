using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium200 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium200";
        public override double halfLife { get; } = 690.6d;
        public override double atomicWeight { get; } = 199.98181d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.889d, new List<RadioactiveSubstance> { new BetaParticle(1, 3429000.0), new Bismuth200() } },
            { 0.111d, new List<RadioactiveSubstance> { new AlphaParticle(7003002.09), new Lead196() } },

        };
    }
}
    
    