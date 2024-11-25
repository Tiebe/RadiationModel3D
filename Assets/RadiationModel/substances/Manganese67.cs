using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Manganese67 : RadioactiveSubstance
    {
        public override string name { get; } = "Manganese67";
        public override double halfLife { get; } = 0.047d;
        public override double atomicWeight { get; } = 66.96395d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Iron67() }, { 1.0d, new BetaParticle(-1, 6064000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    