using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt70m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt70m";
        public override double halfLife { get; } = 0.112d;
        public override double atomicWeight { get; } = 69.95026d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Nickel70() }, { 1.0d, new BetaParticle(-1, 6441950.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    