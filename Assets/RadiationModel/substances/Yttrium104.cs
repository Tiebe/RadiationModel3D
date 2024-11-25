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

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium104() }, { 1.0d, new BetaParticle(-1, 5819000.0) } } },
            { 0.34d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium104() }, { 1.0d, new BetaParticle(-1, 5819000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    