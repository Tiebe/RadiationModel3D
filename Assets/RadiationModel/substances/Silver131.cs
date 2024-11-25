using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver131 : RadioactiveSubstance
    {
        public override string name { get; } = "Silver131";
        public override double halfLife { get; } = 0.035d;
        public override double atomicWeight { get; } = 130.95625d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cadmium131() }, { 1.0d, new BetaParticle(-1, 7231000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    