using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hassium277 : RadioactiveSubstance
    {
        public override string name { get; } = "Hassium277";
        public override double halfLife { get; } = 0.003d;
        public override double atomicWeight { get; } = 277.15178d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> {  } },
            { 0.5d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new AlphaParticle(254437867249.94) } } },

        };
    }
}
    