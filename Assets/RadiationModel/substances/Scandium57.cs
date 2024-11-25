using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium57 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium57";
        public override double halfLife { get; } = 0.013d;
        public override double atomicWeight { get; } = 56.97705d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Titanium57() }, { 1.0d, new BetaParticle(-1, 6510000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    