using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt74 : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt74";
        public override double halfLife { get; } = 0.0313d;
        public override double atomicWeight { get; } = 73.96399d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel74() }, { 1.0d, new BetaParticle(-1, 7580000.0) } } },
            { 0.18d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel74() }, { 1.0d, new BetaParticle(-1, 7580000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    