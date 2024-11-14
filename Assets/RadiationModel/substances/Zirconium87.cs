using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Zirconium87 : RadioactiveSubstance
    {
        public override string name { get; } = "Zirconium87";
        public override double halfLife { get; } = 6048.0d;
        public override double atomicWeight { get; } = 86.91482d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 3671400.0), new Yttrium87() } },

        };
    }
}
    
    