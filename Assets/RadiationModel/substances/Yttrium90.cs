
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium90";
        public override double halfLife { get; } = 230580.0d;
        public override double atomicWeight { get; } = 89.90714d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium90() } },

        };
    }
}
    
    