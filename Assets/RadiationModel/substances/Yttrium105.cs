using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Yttrium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Yttrium105";
        public override double halfLife { get; } = 0.107d;
        public override double atomicWeight { get; } = 104.94571d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium105() }, { 1.0d, new BetaParticle(-1, 5444000.0) } } },
            { 0.82d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Zirconium105() }, { 1.0d, new BetaParticle(-1, 5444000.0) } } },

        };
    }
}
    