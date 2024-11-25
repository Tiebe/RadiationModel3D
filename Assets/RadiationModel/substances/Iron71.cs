using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iron71 : RadioactiveSubstance
    {
        public override string name { get; } = "Iron71";
        public override double halfLife { get; } = 0.0357d;
        public override double atomicWeight { get; } = 70.96572d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Cobalt71() }, { 1.0d, new BetaParticle(-1, 6220000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    