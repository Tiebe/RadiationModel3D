using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic64 : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic64";
        public override double halfLife { get; } = 0.069d;
        public override double atomicWeight { get; } = 63.95756d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Gallium64() }, { 1.0d, new BetaParticle(1, 9651400.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    