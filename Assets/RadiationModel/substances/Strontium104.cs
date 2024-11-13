
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium104";
        public override double halfLife { get; } = 0.0506d;
        public override double atomicWeight { get; } = 103.95302d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Yttrium104() } },

        };
    }
}
    
    