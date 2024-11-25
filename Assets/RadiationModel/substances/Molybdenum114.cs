using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Molybdenum114 : RadioactiveSubstance
    {
        public override string name { get; } = "Molybdenum114";
        public override double halfLife { get; } = 0.058d;
        public override double atomicWeight { get; } = 113.94667d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Technetium114() }, { 1.0d, new BetaParticle(-1, 4460000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    