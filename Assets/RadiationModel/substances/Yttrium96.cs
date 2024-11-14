using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium96 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium96";
        public override double halfLife { get; } = 5.34d;
        public override double atomicWeight { get; } = 95.91591d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 7108860.0), new Zirconium96() } },

        };
    }
}
    
    