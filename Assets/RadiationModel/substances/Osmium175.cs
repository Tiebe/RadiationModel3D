using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium175 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium175";
        public override double halfLife { get; } = 84.0d;
        public override double atomicWeight { get; } = 174.95695d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Tungsten175() }, { 1.0d, new BetaParticle(1, 4764000.0) } } },

        };
    }
}
    