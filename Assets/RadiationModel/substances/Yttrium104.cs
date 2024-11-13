
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium104";
        public override double halfLife { get; } = 0.197d;
        public override double atomicWeight { get; } = 103.94194d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Zirconium104() } },

        };
    }
}
    
    