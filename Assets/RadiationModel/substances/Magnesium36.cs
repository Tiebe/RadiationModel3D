using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium36 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium36";
        public override double halfLife { get; } = 0.0076d;
        public override double atomicWeight { get; } = 36.02188d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Aluminum36() }, { 1.0d, new BetaParticle(-1, 7215000.0) } } },
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },

        };
    }
}
    