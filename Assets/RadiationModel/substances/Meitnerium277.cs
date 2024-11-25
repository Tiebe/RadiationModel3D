using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Meitnerium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Meitnerium277";
        public override double halfLife { get; } = 0.004d;
        public override double atomicWeight { get; } = 277.15353d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.2d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(254439497249.94) } } },

        };
    }
}
    