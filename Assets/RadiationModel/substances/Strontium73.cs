using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Strontium73 : RadioactiveSubstance
    {
        public override string name { get; } = "Strontium73";
        public override double halfLife { get; } = 0.025d;
        public override double atomicWeight { get; } = 72.9657d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Krypton73() }, { 1.0d, new BetaParticle(1, 12301000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    