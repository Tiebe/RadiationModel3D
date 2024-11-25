using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron73 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron73";
        public override double halfLife { get; } = 0.0129d;
        public override double atomicWeight { get; } = 72.97425d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt73() }, { 1.0d, new BetaParticle(-1, 6990000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    