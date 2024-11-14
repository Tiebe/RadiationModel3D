using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium93 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium93";
        public override double halfLife { get; } = 36648.0d;
        public override double atomicWeight { get; } = 92.90958d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2895000.0), new Zirconium93() } },

        };
    }
}
    
    