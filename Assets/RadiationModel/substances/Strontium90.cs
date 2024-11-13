
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium90 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium90";
        public override double halfLife { get; } = 912311482.32d;
        public override double atomicWeight { get; } = 89.90773d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium90() } },

        };
    }
}
    
    