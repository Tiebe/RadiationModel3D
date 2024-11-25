using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium105 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium105";
        public override double halfLife { get; } = 0.039d;
        public override double atomicWeight { get; } = 104.959d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Yttrium105() }, { 1.0d, new BetaParticle(-1, 6190000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    