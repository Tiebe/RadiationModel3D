using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt72m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt72m";
        public override double halfLife { get; } = 0.0599d;
        public override double atomicWeight { get; } = 71.95695d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel72() }, { 1.0d, new BetaParticle(-1, 7063050.0) } } },
            { 0.06d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel72() }, { 1.0d, new BetaParticle(-1, 7063050.0) } } },

        };
    }
}
    