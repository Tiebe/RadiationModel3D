using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Samarium158 : RadioactiveSubstance
    {
        public override string name { get; } = "Samarium158";
        public override double halfLife { get; } = 318.0d;
        public override double atomicWeight { get; } = 157.92995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2018500.0), new Europium158() } },

        };
    }
}
    
    