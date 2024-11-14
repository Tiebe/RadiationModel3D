using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon14 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon14";
        public override double halfLife { get; } = 179874626400.0d;
        public override double atomicWeight { get; } = 14.00324d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 156476.2), new Nitrogen14() } },

        };
    }
}
    
    