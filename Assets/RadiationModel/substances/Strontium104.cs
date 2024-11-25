using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium104 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium104";
        public override double halfLife { get; } = 0.053d;
        public override double atomicWeight { get; } = 103.95302d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium104() }, { 1.0d, new BetaParticle(-1, 5160000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    